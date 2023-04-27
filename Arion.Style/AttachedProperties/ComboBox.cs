using System.Windows;

namespace Arion.Style.AttachedProperties
{
    public class ComboBox
    {
        public static readonly DependencyProperty HelpfulDescriptionProperty = DependencyProperty.RegisterAttached(
            "HelpfulDescription", typeof(string), typeof(ComboBox), new PropertyMetadata(default(string)));

        public static void SetHelpfulDescription(DependencyObject element, string value)
        {
            element.SetValue(HelpfulDescriptionProperty, value);
        }

        public static string GetHelpfulDescription(DependencyObject element)
        {
            return (string)element.GetValue(HelpfulDescriptionProperty);
        }

        public static readonly DependencyProperty TitleProperty = DependencyProperty.RegisterAttached(
            "Title", typeof(string), typeof(ComboBox), new PropertyMetadata(default(string)));

        public static void SetTitle(DependencyObject element, string value)
        {
            element.SetValue(TitleProperty, value);
        }

        public static string GetTitle(DependencyObject element)
        {
            return (string)element.GetValue(TitleProperty);
        }
    }
}