using Ninject;
using Ninject.Modules;
using Perceptron.OCR.Model.Infrastructure;
using Perceptron.OCR.ViewModel.ViewModel.Abstract;
using Perceptron.OCR.ViewModel.ViewModel.Concrete;
using Perceptron.Services.Infrastructure;

namespace Perceptron.OCR.ViewModel.Infrastructure.Ninject
{
    public class OCRViewModelModule : NinjectModule
    {
        public static IKernel StaticKernel { get; private set; }

        public override void Load()
        {
            StaticKernel = Kernel;

            // Bind ViewModels
            Kernel.Bind<IMainViewModel>().To<MainViewModel>().InSingletonScope();

            // Load modules
            Kernel.Load<OCRModelModule>();
            Kernel.Load<ServicesModule>();
        }
    }
}
