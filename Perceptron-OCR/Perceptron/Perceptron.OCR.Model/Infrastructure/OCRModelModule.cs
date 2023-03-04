using Ninject;
using Ninject.Modules;
using Perceptron.OCR.Model.Model.Abstract;
using Perceptron.OCR.Model.Model.Concrete;

namespace Perceptron.OCR.Model.Infrastructure
{
    public class OCRModelModule : NinjectModule
    {
        public static IKernel StaticKernel { get; private set; }

        public override void Load()
        {
            StaticKernel = Kernel;

            // Bind Model
            Kernel.Bind<ICharacter>().To<Character>();
            Kernel.Bind<ICharacters>().To<Characters>().InSingletonScope();
            Kernel.Bind<IPixel>().To<Pixel>();
            Kernel.Bind<IPixels>().To<Pixels>();
        }
    }
}
