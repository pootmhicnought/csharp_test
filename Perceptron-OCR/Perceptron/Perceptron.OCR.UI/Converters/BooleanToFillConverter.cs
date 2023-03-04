using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Perceptron.OCR.UI.Converters
{
    public class BooleanToFillConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool && (bool) value)
                return new SolidColorBrush(Colors.Black);

            return new SolidColorBrush(Colors.White);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var color = value as SolidColorBrush;

            if (color != null)
            {
                if (color.Color == Colors.Black)
                    return true;
                if (color.Color == Colors.White)
                    return false;
            }

            return false;
        }
    }
}
