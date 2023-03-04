using Perceptron.Model.Model.Abstract;

namespace Perceptron.Services.Services.Abstract
{
    internal interface INeuron
    {
        #region Properties

        ICombinationFunction CombinationFunction { get; }
        ITransferFunction TransferFunction { get; }
        IInputs TrainingInputs { get; }
        IInputs TestInputs { get; set; }
        IWeights Weights { get; }
        float Error { get; }

        #endregion


        #region Methods

        void Execute(float learningStep);
        float GetInputPotential();
        float GetTrainingPotential();

        #endregion
    }
}
