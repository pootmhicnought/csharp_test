using System;
using System.Collections.Generic;
using System.Linq;
using Ninject;
using Ninject.Parameters;
using Perceptron.Model.Model.Abstract;
using Perceptron.OCR.Model.Model.Abstract;
using Perceptron.OCR.ViewModel.Infrastructure.Ninject;

namespace Perceptron.OCR.ViewModel.Infrastructure.Helpers
{
    internal static class CharacterHelper
    {
        #region Methods

        public static IInputs TransformCharacterToIInputs(this ICharacter character)
        {
            return character.Pixels.TransformPixelsToIInputs();
        }

        public static IInputs TransformPixelsToIInputs(this IEnumerable<IPixel> pixels)
        {
            // transform pixels into IInputs
            var inputs = OCRViewModelModule.StaticKernel.Get<IInputs>();

            foreach (IPixel pixel in pixels)
                inputs.Add(OCRViewModelModule.StaticKernel.Get<IInput>(new ConstructorArgument("isPositiveValue", pixel.IsSelected)));

            return inputs;
        }

        public static ICharacter TransformIInputsToCharacter(this IInputs inputs, ICharacters characters)
        {
            // transform inputs into IPixels
            var pixels = OCRViewModelModule.StaticKernel.Get<IPixels>();

            for (int i = 0; i < inputs.Count; i++)
                pixels[i].IsSelected = inputs[i].IsPositiveValue;

            // search for the exact ICharacter who match the transformed variable of IPixels
            return pixels.SearchCharacter(characters);
        }

        public static ICharacter SearchCharacter(this IPixels pixels, ICharacters characters)
        {
            // search a character that match the IPixels
            foreach (var character in characters.Values)
                if (IsCorrectCharacter(character, pixels))
                    return character;

            throw new ArgumentNullException();
        }

        public static bool IsCorrectCharacter(this ICharacter character, IPixels pixels)
        {
            return !character.Pixels.Where((pixel, i) => pixel.IsSelected != pixels[i].IsSelected).Any();
        }

        #endregion
    }
}
