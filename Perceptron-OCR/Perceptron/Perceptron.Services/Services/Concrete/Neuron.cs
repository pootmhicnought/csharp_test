using System;
using Ninject;
using Ninject.Parameters;
using Perceptron.Model.Infrastructure;
using Perceptron.Model.Model.Abstract;
using Perceptron.Services.Services.Abstract;

namespace Perceptron.Services.Services.Concrete
{
    internal class Neuron : INeuron
    {
        #region Properties

        private int MaxI
        {
            get
            {
                if (TestInputs != null && Weights != null)
                    return Math.Min(TestInputs.Count, Weights.Count);
                return 0;
            }
        }

        public ICombinationFunction CombinationFunction { get; private set; }
        public ITransferFunction TransferFunction { get; private set; }
        public IInputs TrainingInputs { get; private set; }
        public IInputs TestInputs { get; set; }
        public IWeights Weights { get; private set; }
        public float Error { get; private set; }

        #endregion


        #region Constructor

        public Neuron(ICombinationFunction combinationFunction, ITransferFunction transferFunction, IInputs trainingInputs)
        {
            CombinationFunction = combinationFunction;
            TransferFunction = transferFunction;
            TrainingInputs = trainingInputs;
            Weights = ModelModule.StaticKernel.Get<IWeights>(new ConstructorArgument("numberOfWeights", trainingInputs.Count));
        }

        #endregion


        #region Methods

        public void Execute(float learningStep)
        {
            // Get potential value with combination function
            var potential = GetInputPotential();

            // Get activation value with transfer function
            var activation = TransferFunction.Execute(potential);

            // calculate error with activation and training activation
            var trainingPotential = GetTrainingPotential();
            var trainingActivation = TransferFunction.Execute(trainingPotential);
            Error = trainingActivation - activation;

            // Recalculate weights
            RecalculeWeights(learningStep);
        }

        public float GetInputPotential()
        {
            return CombinationFunction.Execute(TestInputs, Weights);
        }

        public float GetTrainingPotential()
        {
            return CombinationFunction.Execute(TrainingInputs, Weights);
        }

        private void RecalculeWeights(float learningStep)
        {
            // Recalculate weights
            for (int i = 0; i < MaxI; i++)
                Weights[i].Value += (TestInputs[i].Value * learningStep * Error);
        }

        #endregion
    }
}
