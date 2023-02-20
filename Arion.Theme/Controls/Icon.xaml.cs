using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Arion.Theme.Controls
{
    public partial class Icon : UserControl
    {
        public EIcons Kind
        {
            get => (EIcons)GetValue(KindProperty);
            set
            {
                SetValue(KindProperty, value);
                Image = Icons.IconsDictionary.FirstOrDefault(x => x.Key == value).Value;
            }
        }

        public static readonly DependencyProperty KindProperty =
            DependencyProperty.Register(nameof(Kind), typeof(EIcons), typeof(Icon), new PropertyMetadata());

        public Geometry Image
        {
            get => (Geometry)GetValue(ImageProperty);
            set => SetValue(ImageProperty, value);
        }

        public static readonly DependencyProperty ImageProperty =
            DependencyProperty.Register(nameof(Image), typeof(Geometry), typeof(Icon), new PropertyMetadata());

        public Color Fill
        {
            get => (Color)GetValue(FillProperty);
            set
            {
                SetValue(FillProperty, value);
                ImageTest.Fill = new SolidColorBrush(value);
            }
        }

        public static readonly DependencyProperty FillProperty =
            DependencyProperty.Register(nameof(Fill), typeof(Color), typeof(Icon), new PropertyMetadata());

        public new double Height
        {
            get => (double)GetValue(HeightProperty);
            set
            {
                ImageTest.Height = value;
                SetValue(HeightProperty, value);
            }
        }

        public new static readonly DependencyProperty HeightProperty =
            DependencyProperty.Register(nameof(Height), typeof(double), typeof(Icon), new PropertyMetadata());

        public new double Width
        {
            get => (double)GetValue(WidthProperty);
            set
            {
                ImageTest.Width = value;
                SetValue(WidthProperty, value);
            }
        }

        public new static readonly DependencyProperty WidthProperty =
            DependencyProperty.Register(nameof(Width), typeof(double), typeof(Icon), new PropertyMetadata());

        public Icon()
        {
            InitializeComponent();
        }

        private void Icon_OnLoaded(object sender, RoutedEventArgs e)
        {
            Kind = Kind;
            ImageTest.Fill = new SolidColorBrush(Fill);
            Width = Width;
            Height = Height;
        }
    }
}