using System.Windows;
using System.Windows.Controls.Primitives;
using Arion.Style.Controls;

namespace Arion.Style.AttachedProperties
{
    public class Button
    {
        #region Left Icon

        public static readonly DependencyProperty LeftIconProperty = DependencyProperty.RegisterAttached(
            "LeftIcon", typeof(EIcons), typeof(Button), new PropertyMetadata(default(EIcons)));

        public static void SetLeftIcon(System.Windows.Controls.Button element, EIcons value)
        {
            element.SetValue(LeftIconProperty, value);
        }

        public static EIcons GetLeftIcon(System.Windows.Controls.Button element)
        {
            return (EIcons)element.GetValue(LeftIconProperty);
        }

        #endregion

        #region Right Icon

        public static readonly DependencyProperty RightIconProperty = DependencyProperty.RegisterAttached(
            "RightIcon", typeof(EIcons), typeof(Button), new PropertyMetadata(default(EIcons)));

        public static void SetRightIcon(System.Windows.Controls.Button element, EIcons value)
        {
            element.SetValue(RightIconProperty, value);
        }

        public static EIcons GetRightIcon(System.Windows.Controls.Button element)
        {
            return (EIcons)element.GetValue(RightIconProperty);
        }

        #endregion

        #region Center Icon

        public static readonly DependencyProperty IconProperty = DependencyProperty.RegisterAttached(
            "Icon", typeof(EIcons), typeof(Button), new PropertyMetadata(default(EIcons)));

        public static void SetIcon(System.Windows.Controls.Button element, EIcons value)
        {
            element.SetValue(IconProperty, value);
        }

        public static EIcons GetIcon(System.Windows.Controls.Button element)
        {
            return (EIcons)element.GetValue(IconProperty);
        }

        #endregion

        public static readonly DependencyProperty IconWidthProperty = DependencyProperty.RegisterAttached(
            "IconWidth", typeof(double), typeof(Button), new PropertyMetadata(default(double)));

        public static void SetIconWidth(ButtonBase element, double value)
        {
            element.SetValue(IconWidthProperty, value);
        }

        public static double GetIconWidth(ButtonBase element)
        {
            return (double)element.GetValue(IconWidthProperty);
        }

        public static readonly DependencyProperty IconHeightProperty = DependencyProperty.RegisterAttached(
            "IconHeight", typeof(double), typeof(Button), new PropertyMetadata(default(double)));

        public static void SetIconHeight(ButtonBase element, double value)
        {
            element.SetValue(IconHeightProperty, value);
        }

        public static double GetIconHeight(ButtonBase element)
        {
            return (double)element.GetValue(IconHeightProperty);
        }

        #region ProgressBar

        public static readonly DependencyProperty ProgressBarValueProperty = DependencyProperty.RegisterAttached(
            "ProgressBarValue", typeof(double), typeof(Button), new PropertyMetadata(default(double)));

        public static void SetProgressBarValue(ButtonBase element, double value)
        {
            element.SetValue(ProgressBarValueProperty, value);
        }

        public static double GetProgressBarValue(ButtonBase element)
        {
            return (double)element.GetValue(ProgressBarValueProperty);
        }

        public static readonly DependencyProperty ProgressBarMaximumProperty = DependencyProperty.RegisterAttached(
            "ProgressBarMaximum", typeof(double), typeof(Button), new PropertyMetadata(default(double)));

        public static void SetProgressBarMaximum(ButtonBase element, double value)
        {
            element.SetValue(ProgressBarMaximumProperty, value);
        }

        public static double GetProgressBarMaximum(ButtonBase element)
        {
            return (double)element.GetValue(ProgressBarMaximumProperty);
        }

        public static readonly DependencyProperty ProgressBarMinimumProperty = DependencyProperty.RegisterAttached(
            "ProgressBarMinimum", typeof(double), typeof(Button), new PropertyMetadata(default(double)));

        public static void SetProgressBarMinimum(ButtonBase element, double value)
        {
            element.SetValue(ProgressBarMinimumProperty, value);
        }

        public static double GetProgressBarMinimum(ButtonBase element)
        {
            return (double)element.GetValue(ProgressBarMinimumProperty);
        }

        public static readonly DependencyProperty ProgressBarShowProperty = DependencyProperty.RegisterAttached(
            "ProgressBarShow", typeof(bool), typeof(Button), new PropertyMetadata(default(bool)));

        public static void SetProgressBarShow(ButtonBase element, bool value)
        {
            element.SetValue(ProgressBarShowProperty, value);
        }

        public static bool GetProgressBarShow(ButtonBase element) => (bool)element.GetValue(ProgressBarShowProperty);

        public static readonly DependencyProperty ProgressBarTypeProperty = DependencyProperty.RegisterAttached(
            "ProgressBarType", typeof(ProgressBarType), typeof(Button), new PropertyMetadata(default(ProgressBarType)));

        public static void SetProgressBarType(ButtonBase element, ProgressBarType value)
        {
            element.SetValue(ProgressBarTypeProperty, value);
        }

        public static ProgressBarType GetProgressBarType(ButtonBase element)
        {
            return (ProgressBarType)element.GetValue(ProgressBarTypeProperty);
        }
        
        #endregion
    }

    public enum ProgressBarType
    {
        Linear,
        Circle
    }
}