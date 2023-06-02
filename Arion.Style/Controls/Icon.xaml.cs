using System.Linq;
using System.Windows;
using System.Windows.Media;

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

        public Brush Fill
        {
            get => (Brush)GetValue(FillProperty);
            set => SetValue(FillProperty, value);
        }

        public static readonly DependencyProperty FillProperty =
            DependencyProperty.Register(nameof(Fill), typeof(Brush), typeof(Icon), new PropertyMetadata());

        public new double Height
        {
            get => (double)GetValue(HeightProperty);
            set => SetValue(HeightProperty, value);
        }

        public new static readonly DependencyProperty HeightProperty =
            DependencyProperty.Register(nameof(Height), typeof(double), typeof(Icon), new PropertyMetadata(15.0));

        public new double Width
        {
            get => (double)GetValue(WidthProperty);
            set => SetValue(WidthProperty, value);
        }

        public new static readonly DependencyProperty WidthProperty =
            DependencyProperty.Register(nameof(Width), typeof(double), typeof(Icon), new PropertyMetadata(15.0));

        public double Stroke
        {
            get => (double)GetValue(StrokeProperty);
            set => SetValue(StrokeProperty, value);
        }

        public static readonly DependencyProperty StrokeProperty =
            DependencyProperty.Register(nameof(Stroke), typeof(double), typeof(Icon), new PropertyMetadata());

        public SolidColorBrush StrokeColor
        {
            get => (SolidColorBrush)GetValue(StrokeColorProperty);
            set => SetValue(StrokeColorProperty, value);
        }

        public static readonly DependencyProperty StrokeColorProperty =
            DependencyProperty.Register(nameof(StrokeColor), typeof(SolidColorBrush), typeof(Icon), new PropertyMetadata());
        
        public Icon()
        {
            InitializeComponent();
        }
        
        

        private void Icon_OnLoaded(object sender, RoutedEventArgs e)
        {
            Kind = Kind;
            Fill = Fill;
            Width = Width;
            Height = Height;
        }
    }
}