using System.Windows;
using System.Windows.Media;

namespace Arion.Style.AttachedProperties
{
    public class GroupBox
    {
        public static readonly DependencyProperty BackgroundHeaderProperty = DependencyProperty.RegisterAttached(
            "BackgroundHeader", typeof(Brush), typeof(GroupBox), new PropertyMetadata(default(Brush)));

        public static void SetBackgroundHeader(DependencyObject element, Brush value)
        {
            element.SetValue(BackgroundHeaderProperty, value);
        }

        public static Brush GetBackgroundHeader(DependencyObject element)
        {
            return (Brush)element.GetValue(BackgroundHeaderProperty);
        }
    }
}