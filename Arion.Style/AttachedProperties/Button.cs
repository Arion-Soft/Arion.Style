using System.Windows;
using System.Windows.Media;
using Arion.Style.AttachedProperties.Enum;
using Arion.Style.Controls;

namespace Arion.Style.AttachedProperties
{
    public class Button
    {
        #region Left Icon

        public static readonly DependencyProperty LeftIconProperty = DependencyProperty.RegisterAttached(
            "LeftIcon", typeof(EIcons), typeof(Button), new PropertyMetadata(default(EIcons)));

        public static void SetLeftIcon(DependencyObject element, EIcons value)
        {
            element.SetValue(LeftIconProperty, value);
        }

        public static EIcons GetLeftIcon(DependencyObject element)
        {
            return (EIcons)element.GetValue(LeftIconProperty);
        }

        #endregion

        #region Right Icon

        public static readonly DependencyProperty RightIconProperty = DependencyProperty.RegisterAttached(
            "RightIcon", typeof(EIcons), typeof(Button), new PropertyMetadata(default(EIcons)));

        public static void SetRightIcon(DependencyObject element, EIcons value)
        {
            element.SetValue(RightIconProperty, value);
        }

        public static EIcons GetRightIcon(DependencyObject element)
        {
            return (EIcons)element.GetValue(RightIconProperty);
        }

        #endregion

        #region Center Icon

        public static readonly DependencyProperty IconProperty = DependencyProperty.RegisterAttached(
            "Icon", typeof(EIcons), typeof(Button), new PropertyMetadata(default(EIcons)));

        public static void SetIcon(DependencyObject element, EIcons value)
        {
            element.SetValue(IconProperty, value);
        }

        public static EIcons GetIcon(DependencyObject element)
        {
            return (EIcons)element.GetValue(IconProperty);
        }

        #endregion

        public static readonly DependencyProperty IconWidthProperty = DependencyProperty.RegisterAttached(
            "IconWidth", typeof(double), typeof(Button), new PropertyMetadata(default(double)));

        public static void SetIconWidth(DependencyObject element, double value)
        {
            element.SetValue(IconWidthProperty, value);
        }

        public static double GetIconWidth(DependencyObject element)
        {
            return (double)element.GetValue(IconWidthProperty);
        }

        public static readonly DependencyProperty IconHeightProperty = DependencyProperty.RegisterAttached(
            "IconHeight", typeof(double), typeof(Button), new PropertyMetadata(default(double)));

        public static void SetIconHeight(DependencyObject element, double value)
        {
            element.SetValue(IconHeightProperty, value);
        }

        public static double GetIconHeight(DependencyObject element)
        {
            return (double)element.GetValue(IconHeightProperty);
        }

        public static readonly DependencyProperty IconStrokeColorProperty = DependencyProperty.RegisterAttached(
            "IconStrokeColor", typeof(SolidColorBrush), typeof(Button), new PropertyMetadata(default(SolidColorBrush)));

        public static void SetIconStrokeColor(DependencyObject element, SolidColorBrush value)
        {
            element.SetValue(IconStrokeColorProperty, value);
        }

        public static SolidColorBrush GetIconStrokeColor(DependencyObject element)
        {
            return (SolidColorBrush)element.GetValue(IconStrokeColorProperty);
        }

        public static readonly DependencyProperty IconStrokeThicknessProperty = DependencyProperty.RegisterAttached(
            "IconStrokeThickness", typeof(double), typeof(Button), new PropertyMetadata(default(double)));

        public static void SetIconStrokeThickness(DependencyObject element, double value)
        {
            element.SetValue(IconStrokeThicknessProperty, value);
        }

        public static double GetIconStrokeThickness(DependencyObject element)
        {
            return (double)element.GetValue(IconStrokeThicknessProperty);
        }

        #region ProgressBar

        public static readonly DependencyProperty ProgressBarValueProperty = DependencyProperty.RegisterAttached(
            "ProgressBarValue", typeof(double), typeof(Button), new PropertyMetadata(default(double)));

        public static void SetProgressBarValue(DependencyObject element, double value)
        {
            element.SetValue(ProgressBarValueProperty, value);
        }

        public static double GetProgressBarValue(DependencyObject element)
        {
            return (double)element.GetValue(ProgressBarValueProperty);
        }

        public static readonly DependencyProperty ProgressBarMaximumProperty = DependencyProperty.RegisterAttached(
            "ProgressBarMaximum", typeof(double), typeof(Button), new PropertyMetadata(default(double)));

        public static void SetProgressBarMaximum(DependencyObject element, double value)
        {
            element.SetValue(ProgressBarMaximumProperty, value);
        }

        public static double GetProgressBarMaximum(DependencyObject element)
        {
            return (double)element.GetValue(ProgressBarMaximumProperty);
        }

        public static readonly DependencyProperty ProgressBarMinimumProperty = DependencyProperty.RegisterAttached(
            "ProgressBarMinimum", typeof(double), typeof(Button), new PropertyMetadata(default(double)));

        public static void SetProgressBarMinimum(DependencyObject element, double value)
        {
            element.SetValue(ProgressBarMinimumProperty, value);
        }

        public static double GetProgressBarMinimum(DependencyObject element)
        {
            return (double)element.GetValue(ProgressBarMinimumProperty);
        }

        public static readonly DependencyProperty ProgressBarShowProperty = DependencyProperty.RegisterAttached(
            "ProgressBarShow", typeof(bool), typeof(Button), new PropertyMetadata(default(bool)));

        public static void SetProgressBarShow(DependencyObject element, bool value)
        {
            element.SetValue(ProgressBarShowProperty, value);
        }

        public static bool GetProgressBarShow(DependencyObject element) => (bool)element.GetValue(ProgressBarShowProperty);

        public static readonly DependencyProperty ProgressBarTypeProperty = DependencyProperty.RegisterAttached(
            "ProgressBarType", typeof(ProgressBarType), typeof(Button), new PropertyMetadata(default(ProgressBarType)));

        public static void SetProgressBarType(DependencyObject element, ProgressBarType value)
        {
            element.SetValue(ProgressBarTypeProperty, value);
        }

        public static ProgressBarType GetProgressBarType(DependencyObject element)
        {
            return (ProgressBarType)element.GetValue(ProgressBarTypeProperty);
        }
        
        #endregion

        public static readonly DependencyProperty PositionProperty = DependencyProperty.RegisterAttached(
            "Position", typeof(Position), typeof(Button), new PropertyMetadata(default(Position)));

        public static void SetPosition(DependencyObject element, Position value)
        {
            element.SetValue(PositionProperty, value);
        }

        public static Position GetPosition(DependencyObject element)
        {
            return (Position)element.GetValue(PositionProperty);
        }
    }

    public enum ProgressBarType
    {
        Linear,
        Circle
    }
}