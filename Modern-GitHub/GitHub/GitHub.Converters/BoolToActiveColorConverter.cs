using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace GitHub.Converters
{
    public class BoolToActiveColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return (bool) value ? Application.Current.Resources["GreyBlue"] : Application.Current.Resources["GreyBlueDisable"];
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
