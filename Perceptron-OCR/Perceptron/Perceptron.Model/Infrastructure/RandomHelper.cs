using System;
using Ninject;
using Ninject.Parameters;
using Perceptron.Model.Model.Abstract;

namespace Perceptron.Model.Infrastructure
{
    internal static class RandomHelper
    {
        #region Fields

        private static readonly Random Random = new Random();

        #endregion


        #region Methods

        public static IWeight RandomWeight()
        {
            return ModelModule.StaticKernel.Get<IWeight>(new ConstructorArgument("value", (float)(Random.NextDouble() * 2 - 1)));
        }

        #endregion
    }
}
