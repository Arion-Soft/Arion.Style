using System.Linq;
using System.Windows;
using System.Windows.Media;
using Arion.Style.Controls.Icons;

namespace Arion.Style.Controls
{
    public partial class Icon
    {
        public EIcons Kind
        {
            get => (EIcons)GetValue(KindProperty);
            set
            {
                SetValue(KindProperty, value);
                Image = Geometry.Parse(IconLibrary.IconsDictionary.FirstOrDefault(x => x.Key == value).Value);
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

        public SolidColorBrush Fill
        {
            get => (SolidColorBrush)GetValue(FillProperty);
            set
            {
                SetValue(FillProperty, value);
                ImageTest.Fill = value;
            }
        }

        public static readonly DependencyProperty FillProperty =
            DependencyProperty.Register(nameof(Fill), typeof(SolidColorBrush), typeof(Icon), new PropertyMetadata());

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
            Fill = new SolidColorBrush(Color.FromRgb(0x0,0x0,0x0));
            Width = 20;
            Height = 20;
        }

        private void Icon_OnLoaded(object sender, RoutedEventArgs e)
        {
            Kind = Kind;
            ImageTest.Fill = Fill;
            Width = Width;
            Height = Height;
        }
    }
}