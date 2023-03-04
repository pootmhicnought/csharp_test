using System;
using Perceptron.Services.Services.Abstract;

namespace Perceptron.Services.Services.Concrete
{
    internal class SigmoidTransferFunction : ITransferFunction
    {
        public float Execute(float value)
        {
            float denominateur = 1 + (float)Math.Exp(-value);
            return 1/denominateur;
        }
    }
}
