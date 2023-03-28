using System;
using System.Globalization;
using System.Windows.Data;

namespace Arion.Style.Converters
{
    public class ButtonProgressBarWidthConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                var width = (double)value;
                var progressWidth = width - 24;
                return progressWidth < 16 ? 16 : progressWidth;
            }

            return 56;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}