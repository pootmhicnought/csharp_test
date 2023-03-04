using Ninject;
using Ninject.Modules;
using Perceptron.Model.Infrastructure;
using Perceptron.Services.Services.Abstract;
using Perceptron.Services.Services.Concrete;

namespace Perceptron.Services.Infrastructure
{
    public class ServicesModule : NinjectModule
    {
        public static IKernel StaticKernel { get; private set; }

        public override void Load()
        {
            StaticKernel = Kernel;

            // Bind Services
            Kernel.Bind<INeuron>().To<Neuron>();
            Kernel.Bind<IPerceptronService>().To<SingleLayerPerceptronService>().InSingletonScope();
            Kernel.Bind<ICombinationFunction>().To<RosenblattCombinationFunction>();
            Kernel.Bind<ITransferFunction>().To<SigmoidTransferFunction>().InSingletonScope();

            // Load modules
            Kernel.Load<ModelModule>();
        }
    }
}
