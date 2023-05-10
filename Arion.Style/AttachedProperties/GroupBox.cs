using System.Windows;
using System.Windows.Media;

namespace Arion.Style.AttachedProperties
{
    public class GroupBox
    {
        public static readonly DependencyProperty BackgroundHeaderProperty = DependencyProperty.RegisterAttached(
            "BackgroundHeader", typeof(SolidColorBrush), typeof(GroupBox), new PropertyMetadata(default(SolidColorBrush)));

        public static void SetBackgroundHeader(DependencyObject element, SolidColorBrush value)
        {
            element.SetValue(BackgroundHeaderProperty, value);
        }

        public static SolidColorBrush GetBackgroundHeader(DependencyObject element)
        {
            return (SolidColorBrush)element.GetValue(BackgroundHeaderProperty);
        }
    }
}