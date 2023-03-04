using System.Collections.Generic;
using Perceptron.Model.Infrastructure;
using Perceptron.Model.Model.Abstract;

namespace Perceptron.Model.Model.Concrete
{
    internal class Weights : List<IWeight>, IWeights
    {
        #region Constructor

        public Weights(int numberOfWeights)
        {
            for (int i = 0; i < numberOfWeights; i++)
                Add(RandomHelper.RandomWeight());
        }

        #endregion
    }
}
