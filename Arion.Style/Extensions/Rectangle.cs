using System.Windows;

namespace Arion.Style.Extensions
{
    public class Rectangle : DependencyObject
    {
        public double Width
        {
            get => (double)GetValue(WidthProperty);
            set => SetValue(WidthProperty, value);
        }

        public static readonly DependencyProperty WidthProperty =
            DependencyProperty.Register(nameof(Width), typeof(double), typeof(Rectangle), new PropertyMetadata(10.0));

        public double Height
        {
            get => (double)GetValue(HeightProperty);
            set => SetValue(HeightProperty, value);
        }

        public static readonly DependencyProperty HeightProperty =
            DependencyProperty.Register(nameof(Height), typeof(double), typeof(Rectangle), new PropertyMetadata(10.0));

        public Rectangle()
        {
            
        }
    }
}