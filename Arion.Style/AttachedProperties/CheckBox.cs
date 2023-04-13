using System.Windows;

namespace Arion.Style.AttachedProperties
{
    public class CheckBox
    {
        #region Description

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

        #endregion

        #region MarkWidth

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

        #endregion

        #region MarkHeight

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

        #endregion

        #region BoxMarkWidth

        public static readonly DependencyProperty BoxMarkWidthProperty = DependencyProperty.RegisterAttached(
            "BoxMarkWidth", typeof(double), typeof(CheckBox), new PropertyMetadata(default(double)));

        public static void SetBoxMarkWidth(DependencyObject element, double value)
        {
            element.SetValue(BoxMarkWidthProperty, value);
        }

        public static double GetBoxMarkWidth(DependencyObject element)
        {
            return (double)element.GetValue(BoxMarkWidthProperty);
        }

        #endregion

        #region BoxMarkHeight

        public static readonly DependencyProperty BoxMarkHeightProperty = DependencyProperty.RegisterAttached(
            "BoxMarkHeight", typeof(double), typeof(CheckBox), new PropertyMetadata(default(double)));

        public static void SetBoxMarkHeight(DependencyObject element, double value)
        {
            element.SetValue(BoxMarkHeightProperty, value);
        }

        public static double GetBoxMarkHeight(DependencyObject element)
        {
            return (double)element.GetValue(BoxMarkHeightProperty);
        }

        #endregion
    }
}