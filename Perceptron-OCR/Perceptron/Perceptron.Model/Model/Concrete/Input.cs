using Perceptron.Model.Model.Abstract;

namespace Perceptron.Model.Model.Concrete
{
    internal class Input : IInput
    {
        #region Fields

        private readonly bool _isPositiveValue;

        #endregion


        #region Properties

        public int Value { get { return _isPositiveValue ? 1 : -1; } }
        public bool IsPositiveValue { get { return _isPositiveValue; } }

        #endregion


        #region Constructor

        public Input(bool isPositiveValue = false)
        {
            _isPositiveValue = isPositiveValue;
        }

        #endregion
    }
}
