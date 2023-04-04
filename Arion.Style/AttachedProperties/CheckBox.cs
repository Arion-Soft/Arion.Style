using System.Windows;

namespace Arion.Style.AttachedProperties
{
    public class CheckBox
    {
        public static readonly DependencyProperty DescriptionProperty = DependencyProperty.RegisterAttached(
            "Description", typeof(string), typeof(CheckBox), new PropertyMetadata(default(string)));

        public static void SetDescription(DependencyObject element, string value)
        {
            element.SetValue(DescriptionProperty, value);
        }

        public static string GetDescription(DependencyObject element)
        {
            return (string)element.GetValue(DescriptionProperty);
        }
    }
}