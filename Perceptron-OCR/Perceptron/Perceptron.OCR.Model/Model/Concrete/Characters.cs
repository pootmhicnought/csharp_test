using System.Collections.Generic;
using System.Linq;
using Perceptron.OCR.Model.Model.Abstract;

namespace Perceptron.OCR.Model.Model.Concrete
{
    internal class Characters : Dictionary<char, ICharacter>, ICharacters
    {
        #region Properties

        public ICharacter A { get { return this.FirstOrDefault(pair => pair.Key == 'a').Value; } }
        public ICharacter B { get { return this.FirstOrDefault(pair => pair.Key == 'b').Value; } }
        public ICharacter C { get { return this.FirstOrDefault(pair => pair.Key == 'c').Value; } }

        #endregion


        #region Constructor

        public Characters()
        {
            // Create characters
            Add('a', new Character
            {
                Pixels = new Pixels(new List<bool>
                { 
                    false, false, true,   true,   true,   true,   false,  false,
                    false, true,  false,  false,  false,  false,  true,   false,
                    false, false, false,  false,  false,  false,  true,   false,
                    false, false, false,  true,   true,   true,   true,   false,
                    false, false, true,   false,  false,  false,  true,   false,
                    false, true,  false,  false,  false,  false,  true,   false,
                    false, true,  false,  false,  false,  true,   true,   false,
                    false, false, true,   true,   true,   false,  true,   false
                }),
                Name = 'a'
            });

            Add('b', new Character
            {
                Pixels = new Pixels(new List<bool>
                {
                    false, true, false,   false,  false,  false,  false, false,
                    false, true, false,   false,  false,  false,  false, false,
                    false, true, false,   true,   true,   false,  false, false,
                    false, true, true,    false,  false,  true,   false, false,
                    false, true, false,   false,  false,  true,   false, false,
                    false, true, false,   false,  false,  true,   false, false,
                    false, true, true,    false,  false,  true,   false, false,
                    false, true, false,   true,   true,   false,  false, false
                }),
                Name = 'b'
            });

            Add('c', new Character
            {
                Pixels = new Pixels(new List<bool>
                {
                    false, false, true,   true,   true,   true,   false,  false,
                    false, true,  false,  false,  false,  false,  true,   false,
                    false, true,  false,  false,  false,  false,  false,  false,
                    false, true,  false,  false,  false,  false,  false,  false,
                    false, true,  false,  false,  false,  false,  false,  false,
                    false, true,  false,  false,  false,  false,  false,  false,
                    false, true,  false,  false,  false,  false,  true,   false,
                    false, false, true,   true,   true,   true,   false,  false
                }),
                Name = 'c'
            });
        }

        #endregion
    }
}
