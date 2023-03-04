using System.Windows.Controls;
using System.Windows.Input;
using Perceptron.OCR.Model.Model.Abstract;
using Perceptron.OCR.ViewModel.ViewModel.Abstract;

namespace Perceptron.OCR.UI.UserControls
{
    /// <summary>
    /// Logique d'interaction pour RectanglePixel.xaml
    /// </summary>
    public partial class RectanglePixel : UserControl
    {
        #region Fields

        private IMainViewModel _mainViewModel;

        #endregion

        #region Properties

        public IPixel Pixel { get; private set; }

        #endregion


        #region Constructor

        public RectanglePixel(IMainViewModel mainViewModel, IPixel pixel)
        {
            Pixel = pixel;
            _mainViewModel = mainViewModel;

            DataContext = _mainViewModel;

            InitializeComponent();
        }

        #endregion


        #region Events

        private void Rectangle_OnMouseEnter(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                _mainViewModel.SwitchSelectionCommand.Execute(Pixel);
        }

        private void Rectangle_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _mainViewModel.SwitchSelectionCommand.Execute(Pixel);
        }

        #endregion
    }
}
