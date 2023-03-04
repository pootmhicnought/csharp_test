namespace Perceptron.OCR.Model.Model.Abstract
{
    public interface ICharacter
    {
        char Name { get; set; }
        IPixels Pixels { get; set; }
    }
}
