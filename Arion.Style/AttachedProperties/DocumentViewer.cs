using System.Windows;

namespace Arion.Style.AttachedProperties
{
    public class DocumentViewer
    {
        public static readonly DependencyProperty ShowPrintProperty = DependencyProperty.RegisterAttached(
            "ShowPrint", typeof(bool), typeof(DocumentViewer), new PropertyMetadata(default(bool)));

        public static void SetShowPrint(DependencyObject element, bool value)
        {
            element.SetValue(ShowPrintProperty, value);
        }

        public static bool GetShowPrint(DependencyObject element)
        {
            return (bool)element.GetValue(ShowPrintProperty);
        }

        public static readonly DependencyProperty ShowContentCopyProperty = DependencyProperty.RegisterAttached(
            "ShowContentCopy", typeof(bool), typeof(DocumentViewer), new PropertyMetadata(default(bool)));

        public static void SetShowContentCopy(DependencyObject element, bool value)
        {
            element.SetValue(ShowContentCopyProperty, value);
        }

        public static bool GetShowContentCopy(DependencyObject element)
        {
            return (bool)element.GetValue(ShowContentCopyProperty);
        }

        public static readonly DependencyProperty ShowMagnifyPlusProperty = DependencyProperty.RegisterAttached(
            "ShowMagnifyPlus", typeof(bool), typeof(DocumentViewer), new PropertyMetadata(default(bool)));

        public static void SetShowMagnifyPlus(DependencyObject element, bool value)
        {
            element.SetValue(ShowMagnifyPlusProperty, value);
        }

        public static bool GetShowMagnifyPlus(DependencyObject element)
        {
            return (bool)element.GetValue(ShowMagnifyPlusProperty);
        }

        public static readonly DependencyProperty ShowMagnifyMinusProperty = DependencyProperty.RegisterAttached(
            "ShowMagnifyMinus", typeof(bool), typeof(DocumentViewer), new PropertyMetadata(default(bool)));

        public static void SetShowMagnifyMinus(DependencyObject element, bool value)
        {
            element.SetValue(ShowMagnifyMinusProperty, value);
        }

        public static bool GetShowMagnifyMinus(DependencyObject element)
        {
            return (bool)element.GetValue(ShowMagnifyMinusProperty);
        }

        public static readonly DependencyProperty ShowStretchProperty = DependencyProperty.RegisterAttached(
            "ShowStretch", typeof(bool), typeof(DocumentViewer), new PropertyMetadata(default(bool)));

        public static void SetShowStretch(DependencyObject element, bool value)
        {
            element.SetValue(ShowStretchProperty, value);
        }

        public static bool GetShowStretch(DependencyObject element)
        {
            return (bool)element.GetValue(ShowStretchProperty);
        }
    }
}