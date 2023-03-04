using System.Windows;
using Ninject;
using Perceptron.OCR.UI.View;
using Perceptron.OCR.ViewModel.Infrastructure.Ninject;

namespace Perceptron.OCR.UI
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        #region Fields

        private IKernel _kernel;

        #endregion


        #region Events

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            _kernel = new StandardKernel();
            AddBindings();

            GenerateMainWindow();
            Current.MainWindow.Show();
        }

        #endregion


        #region Methods

        private void AddBindings()
        {
            _kernel.Load<OCRViewModelModule>();
        }

        private void GenerateMainWindow()
        {
            Current.MainWindow = _kernel.Get<MainWindow>();
        }

        #endregion
    }
}
