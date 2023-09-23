using System;
using System.Globalization;
using Xamarin.Forms;

namespace TrainingXamarin.Converters
{
    public class LongToFormattedString: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((long)value).ToString("N0");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return long.Parse((string) value);
        }
    }
}