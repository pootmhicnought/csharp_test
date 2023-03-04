using System.Windows;
using System.Windows.Controls;
using Perceptron.OCR.UI.UserControls;
using Perceptron.OCR.ViewModel.ViewModel.Abstract;

namespace Perceptron.OCR.UI.View
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Fields

        private readonly IMainViewModel _mainViewModel;

        #endregion


        #region Constructor

        public MainWindow(IMainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
            DataContext = _mainViewModel;

            InitializeComponent();

            GeneratePixels();
        }

        #endregion


        #region Methods

        private void GeneratePixels()
        {
            // Generate rows of the grid
            for (int i = 0; i < _mainViewModel.Rows; i++)
                Pixels.RowDefinitions.Add(new RowDefinition());

            // Generate columns of the grid
            for (int j = 0; j < _mainViewModel.Columns; j++)
                Pixels.ColumnDefinitions.Add(new ColumnDefinition());

            // Generate pixels
            for (int i = 0; i < _mainViewModel.Rows; i++)
            {
                for (int j = 0; j < _mainViewModel.Columns; j++)
                {
                    int current = i * _mainViewModel.Rows + j;
                    var rectanglePixel = new RectanglePixel(_mainViewModel, _mainViewModel.InputPixels[current]);

                    Grid.SetRow(rectanglePixel, i);
                    Grid.SetColumn(rectanglePixel, j);
                    Pixels.Children.Add(rectanglePixel);
                }
            }
        }

        #endregion
    }
}
