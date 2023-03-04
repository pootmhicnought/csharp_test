using System.Collections.Generic;
using Perceptron.Model.Model.Abstract;

namespace Perceptron.Services.Services.Abstract
{
    public interface IPerceptronService
    {
        #region Properties

        IInputs TestInputs { get; set; }
        IList<IInputs> CompareInputs { get; set; }
        IInputs ResultInputs { get; }
        float LearningStep { get; }
        int NumberOfIterations { get; }
        float Epsilon { get; }

        #endregion


        #region Methods

        void Execute();

        #endregion
    }
}
