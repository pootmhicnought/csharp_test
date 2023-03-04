using System;
using System.Linq;
using Perceptron.Model.Model.Abstract;
using Perceptron.Services.Services.Abstract;

namespace Perceptron.Services.Services.Concrete
{
    internal class RosenblattCombinationFunction : ICombinationFunction
    {
        #region Properties

        public float Limit { get { return 3f; } }

        #endregion


        #region Methods

        public float Execute(IInputs inputs, IWeights weights)
        {
            if (inputs.Count != weights.Count)
                throw new Exception();

            // Calculate sum of each Input * Weight
            float sum = inputs.Select((t, i) => t.Value * weights[i].Value).Sum();
            return sum - Limit;
        }

        #endregion
    }
}
