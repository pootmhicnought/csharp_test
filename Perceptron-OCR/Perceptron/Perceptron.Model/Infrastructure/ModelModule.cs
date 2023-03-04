using Ninject;
using Ninject.Modules;
using Perceptron.Model.Model.Abstract;
using Perceptron.Model.Model.Concrete;

namespace Perceptron.Model.Infrastructure
{
    public class ModelModule : NinjectModule
    {
        public static IKernel StaticKernel { get; private set; }

        public override void Load()
        {
            StaticKernel = Kernel;

            // Bind Model
            Kernel.Bind<IInput>().To<Input>();
            Kernel.Bind<IInputs>().To<Inputs>();
            Kernel.Bind<IWeight>().To<Weight>();
            Kernel.Bind<IWeights>().To<Weights>();
        }
    }
}
