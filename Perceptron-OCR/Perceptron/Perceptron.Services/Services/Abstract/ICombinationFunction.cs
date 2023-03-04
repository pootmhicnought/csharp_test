using Perceptron.Model.Model.Abstract;

namespace Perceptron.Services.Services.Abstract
{
    internal interface ICombinationFunction
    {
        #region Properties

        float Limit { get; }

        #endregion


        #region Methods

        float Execute(IInputs inputs, IWeights weights);

        #endregion
    }
}
