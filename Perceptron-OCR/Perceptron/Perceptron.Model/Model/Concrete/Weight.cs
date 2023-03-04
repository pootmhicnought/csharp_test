using Perceptron.Model.Model.Abstract;

namespace Perceptron.Model.Model.Concrete
{
    internal class Weight : IWeight
    {
        #region Properties

        public float Value { get; set; }

        #endregion


        #region Constructor

        public Weight(float value = 0f)
        {
            Value = value;
        }

        #endregion
    }
}
