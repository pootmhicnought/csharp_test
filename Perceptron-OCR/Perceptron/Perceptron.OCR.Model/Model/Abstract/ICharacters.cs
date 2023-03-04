using System.Collections.Generic;

namespace Perceptron.OCR.Model.Model.Abstract
{
    public interface ICharacters : IDictionary<char, ICharacter>
    {
        ICharacter A { get; }
        ICharacter B { get; }
        ICharacter C { get; }
    }
}
