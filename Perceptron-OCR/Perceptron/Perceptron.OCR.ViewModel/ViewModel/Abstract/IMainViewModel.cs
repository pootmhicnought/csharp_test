using System.Windows.Input;
using Perceptron.OCR.Model.Model.Abstract;
using Perceptron.Services.Services.Abstract;

namespace Perceptron.OCR.ViewModel.ViewModel.Abstract
{
    public interface IMainViewModel : IViewModel
    {
        #region Properties

        int Rows { get; }
        int Columns { get; }
        IPixels InputPixels { get; }
        string Result { get; }

        IPerceptronService PerceptronService { get; }

        ICommand ExecuteCommand { get; }
        ICommand ClearWhiteCommand { get; }
        ICommand SwitchSelectionCommand { get; }
        ICommand SwitchAllCommand { get; }

        #endregion
    }
}
