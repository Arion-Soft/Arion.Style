using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Arion.Style.Converters
{
    public class OutlinedDateTimePickerActiveBorderThicknessConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Length == 2
                && values[0] is Thickness baseThickness
                && values[1] is Thickness thicknessToSubtract)
            {
                var thickness = new Thickness(baseThickness.Left - thicknessToSubtract.Left,
                    baseThickness.Top - thicknessToSubtract.Top,
                    baseThickness.Right - thicknessToSubtract.Right,
                    baseThickness.Bottom - thicknessToSubtract.Bottom);
                return thickness;
            }
            return default(Thickness);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture) => throw new NotImplementedException();
    }
}