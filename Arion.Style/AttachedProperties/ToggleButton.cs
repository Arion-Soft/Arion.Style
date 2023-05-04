using System.Windows;

namespace Arion.Style.AttachedProperties
{
    public class ToggleButton
    {
        public static readonly DependencyProperty AngleProperty = DependencyProperty.RegisterAttached(
            "Angle", typeof(double), typeof(ToggleButton), new PropertyMetadata(0.0));

        public static void SetAngle(DependencyObject element, double value)
        {
            element.SetValue(AngleProperty, value);
        }

        public static double GetAngle(DependencyObject element)
        {
            return (double)element.GetValue(AngleProperty);
        }

        public static readonly DependencyProperty WidthMainBorderProperty = DependencyProperty.RegisterAttached(
            "WidthMainBorder", typeof(double), typeof(ToggleButton), new PropertyMetadata(default(double)));

        public static void SetWidthMainBorder(DependencyObject element, double value)
        {
            element.SetValue(WidthMainBorderProperty, value);
        }

        public static double GetWidthMainBorder(DependencyObject element)
        {
            return (double)element.GetValue(WidthMainBorderProperty);
        }

        public static readonly DependencyProperty HeightMainBorderProperty = DependencyProperty.RegisterAttached(
            "HeightMainBorder", typeof(double), typeof(ToggleButton), new PropertyMetadata(default(double)));

        public static void SetHeightMainBorder(DependencyObject element, double value)
        {
            element.SetValue(HeightMainBorderProperty, value);
        }

        public static double GetHeightMainBorder(DependencyObject element)
        {
            return (double)element.GetValue(HeightMainBorderProperty);
        }

        public static readonly DependencyProperty WidthCheckBorderProperty = DependencyProperty.RegisterAttached(
            "WidthCheckBorder", typeof(double), typeof(ToggleButton), new PropertyMetadata(default(double)));

        public static void SetWidthCheckBorder(DependencyObject element, double value)
        {
            element.SetValue(WidthCheckBorderProperty, value);
        }

        public static double GetWidthCheckBorder(DependencyObject element)
        {
            return (double)element.GetValue(WidthCheckBorderProperty);
        }

        public static readonly DependencyProperty HeightCheckBorderProperty = DependencyProperty.RegisterAttached(
            "HeightCheckBorder", typeof(double), typeof(ToggleButton), new PropertyMetadata(default(double)));

        public static void SetHeightCheckBorder(DependencyObject element, double value)
        {
            element.SetValue(HeightCheckBorderProperty, value);
        }

        public static double GetHeightCheckBorder(DependencyObject element)
        {
            return (double)element.GetValue(HeightCheckBorderProperty);
        }

        public static readonly DependencyProperty ValueMoveProperty = DependencyProperty.RegisterAttached(
            "ValueMove", typeof(Thickness), typeof(ToggleButton), new PropertyMetadata(default(Thickness)));

        public static void SetValueMove(DependencyObject element, Thickness value)
        {
            element.SetValue(ValueMoveProperty, value);
        }

        public static Thickness GetValueMove(DependencyObject element)
        {
            return (Thickness)element.GetValue(ValueMoveProperty);
        }
    }
}