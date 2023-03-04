using System.ComponentModel;
using Perceptron.OCR.Model.Annotations;
using Perceptron.OCR.Model.Model.Abstract;

namespace Perceptron.OCR.Model.Model.Concrete
{
    internal class Pixel : IPixel, INotifyPropertyChanged
    {
        #region Properties

        private bool _isSelected;
        public bool IsSelected { get { return _isSelected; } set { _isSelected = value; RaisePropertyChanged("IsSelected"); } }

        #endregion


        #region Constructor

        public Pixel(bool isSelected = false)
        {
            IsSelected = isSelected;
        }

        #endregion


        #region Property Changed Implementation

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) 
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
