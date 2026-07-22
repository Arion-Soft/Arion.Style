using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace Arion.Style.Controls
{
    /// <summary>
    /// Represents a scalable vector icon control that renders a geometry based on a specified icon kind.
    /// </summary>
    public partial class Icon
    {
        /// <summary>
        /// Gets or sets the type of icon to display.
        /// </summary>
        public EIcons Kind
        {
            get => (EIcons)GetValue(KindProperty);
            set => SetValue(KindProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="Kind"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty KindProperty =
            DependencyProperty.Register(
                nameof(Kind),
                typeof(EIcons),
                typeof(Icon),
                new PropertyMetadata(default(EIcons), OnKindChanged));

        /// <summary>
        /// Callback invoked when the <see cref="Kind"/> property changes, updating the rendered geometry.
        /// </summary>
        /// <param name="d">The dependency object.</param>
        /// <param name="e">The event data containing the old and new values.</param>
        private static void OnKindChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Icon icon && e.NewValue is EIcons kind)
            {
                var iconData = IconLibrary.IconsDictionary.FirstOrDefault(x => x.Key == kind).Value;
                if (iconData != null)
                {
                    icon.Image = Geometry.Parse(iconData);
                }
            }
        }

        /// <summary>
        /// Gets or sets the geometric shape of the icon.
        /// </summary>
        public Geometry Image
        {
            get => (Geometry)GetValue(ImageProperty);
            set => SetValue(ImageProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="Image"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty ImageProperty =
            DependencyProperty.Register(nameof(Image), typeof(Geometry), typeof(Icon), new PropertyMetadata());

        /// <summary>
        /// Gets or sets the brush used to fill the icon's geometry.
        /// </summary>
        public Brush Fill
        {
            get => (Brush)GetValue(FillProperty);
            set => SetValue(FillProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="Fill"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty FillProperty =
            DependencyProperty.Register(nameof(Fill), typeof(Brush), typeof(Icon), new FrameworkPropertyMetadata(default(Brush), FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        /// <summary>
        /// Gets or sets the thickness of the icon's outline.
        /// </summary>
        public double Stroke
        {
            get => (double)GetValue(StrokeProperty);
            set => SetValue(StrokeProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="Stroke"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty StrokeProperty =
            DependencyProperty.Register(nameof(Stroke), typeof(double), typeof(Icon), new PropertyMetadata(0.0));

        /// <summary>
        /// Gets or sets the color of the icon's outline.
        /// </summary>
        public SolidColorBrush StrokeColor
        {
            get => (SolidColorBrush)GetValue(StrokeColorProperty);
            set => SetValue(StrokeColorProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="StrokeColor"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty StrokeColorProperty =
            DependencyProperty.Register(nameof(StrokeColor), typeof(SolidColorBrush), typeof(Icon), new PropertyMetadata(Brushes.Black));

        /// <summary>
        /// Initializes a new instance of the <see cref="Icon"/> class.
        /// </summary>
        public Icon()
        {
            InitializeComponent();
        }
    }
}