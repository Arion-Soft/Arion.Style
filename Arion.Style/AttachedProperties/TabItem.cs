using System.Windows;

namespace Arion.Style.AttachedProperties
{
    public class TabItem
    {
        public static readonly DependencyProperty MainBorderProperty = DependencyProperty.RegisterAttached(
            "MainBorder", typeof(Thickness), typeof(TabItem), new PropertyMetadata(default(Thickness)));

        public static void SetMainBorder(DependencyObject element, Thickness value)
        {
            element.SetValue(MainBorderProperty, value);
        }

        public static Thickness GetMainBorder(DependencyObject element)
        {
            return (Thickness)element.GetValue(MainBorderProperty);
        }
    }
}