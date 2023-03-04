using Perceptron.OCR.Model.Model.Abstract;

namespace Perceptron.OCR.Model.Model.Concrete
{
    internal class Character : ICharacter
    {
        public char Name { get; set; }
        public IPixels Pixels { get; set; }
    }
}
