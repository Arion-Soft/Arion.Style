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

        public static readonly DependencyProperty MarkWidthProperty = DependencyProperty.RegisterAttached(
            "MarkWidth", typeof(double), typeof(CheckBox), new PropertyMetadata(default(double)));

        public static void SetMarkWidth(DependencyObject element, double value)
        {
            element.SetValue(MarkWidthProperty, value);
        }

        public static double GetMarkWidth(DependencyObject element)
        {
            return (double)element.GetValue(MarkWidthProperty);
        }

        public static readonly DependencyProperty MarkHeightProperty = DependencyProperty.RegisterAttached(
            "MarkHeight", typeof(double), typeof(CheckBox), new PropertyMetadata(default(double)));

        public static void SetMarkHeight(DependencyObject element, double value)
        {
            element.SetValue(MarkHeightProperty, value);
        }

        public static double GetMarkHeight(DependencyObject element)
        {
            return (double)element.GetValue(MarkHeightProperty);
        }
    }
}