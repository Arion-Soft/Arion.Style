using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using Arion.Theme.Extensions;

namespace Arion.Theme.Converters
{
    internal class FloatingHintOffsetCalculationConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Length > 3 &&
                values[3] is Point floatingOffset &&
                IsType<Point>(targetType) &&
                floatingOffset != HintAssist.DefaultFloatingOffset)
            {
                return floatingOffset;
            }
    
            var fontFamily = (FontFamily)values[0];
            double fontSize = (double)values[1];
            double floatingScale = (double)values[2];
    
            double hintHeight = fontFamily.LineSpacing * fontSize;
            double floatingHintHeight = hintHeight * floatingScale;

            double offset = 0;
            switch (values.Length > 4 ? values[4] : null)
            {

                case Thickness padding:
                {
                    offset = floatingHintHeight / 2 + padding.Top;
                    break;
                }
                case double parentHeight:
                {
                    offset = (parentHeight - hintHeight + floatingHintHeight) / 2;
                    break;
                }
                case null:
                {
                    offset = floatingHintHeight;
                    break;
                }
            };
    
            if (IsType<Point>(targetType))
            {
                return new Point(0, -offset);
            }
    
            if (IsType<Thickness>(targetType))
            {
                return new Thickness(0, offset, 0, 0);
            }
    
            return new Thickness(0, offset, 0, 0);
            throw new NotSupportedException(targetType.FullName);
        }
    
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture) => throw new NotSupportedException();
    
        private bool IsType<T>(Type type) => type == typeof(T);
    }
}
