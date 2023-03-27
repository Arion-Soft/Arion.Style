using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Arion.Style.Controls.Enums;

namespace Arion.Style.Controls
{
    public partial class BreadcrumbItem
    {
        public BreadcrumbItem()
        {
            InitializeComponent();
            Type = Type;
        }

        public BreadcrumbItemType Type
        {
            get => (BreadcrumbItemType)GetValue(TypeProperty);
            set
            {
                SetValue(TypeProperty, value);
                if (value == BreadcrumbItemType.File)
                {
                    Kind = EIcons.File;
                    IconWidth = 12;
                    IconHeight = 16;
                    IconMargin = new Thickness(6, 4, 6, 4);
                    ForegroundLabel = new SolidColorBrush(Color.FromRgb(0x25, 0x2C, 0x32));
                }
                else if (value == BreadcrumbItemType.Folder)
                {
                    Kind = EIcons.Folder;
                    IconWidth = 16;
                    IconHeight = 12;
                    IconMargin = new Thickness(4, 6, 4, 6);
                    ForegroundLabel = new SolidColorBrush(Color.FromRgb(0x6E, 0x7C, 0x87)); 
                }
            }
        }

        public static readonly DependencyProperty TypeProperty =
            DependencyProperty.Register(nameof(Type), typeof(BreadcrumbItemType), typeof(BreadcrumbItem),
                new PropertyMetadata());

        public SolidColorBrush ForegroundLabel
        {
            get => (SolidColorBrush)GetValue(ForegroundLabelProperty);
            set => SetValue(ForegroundLabelProperty, value);
        }

        public static readonly DependencyProperty ForegroundLabelProperty =
            DependencyProperty.Register(nameof(ForegroundLabel), typeof(SolidColorBrush), typeof(BreadcrumbItem), new PropertyMetadata());

        public double IconWidth
        {
            get => (double)GetValue(IconWidthProperty);
            set => SetValue(IconWidthProperty, value);
        }

        public static readonly DependencyProperty IconWidthProperty =
            DependencyProperty.Register(nameof(IconWidth), typeof(double), typeof(BreadcrumbItem), new PropertyMetadata());

        public double IconHeight
        {
            get => (double)GetValue(IconHeightProperty);
            set => SetValue(IconHeightProperty, value);
        }

        public static readonly DependencyProperty IconHeightProperty =
            DependencyProperty.Register(nameof(IconHeight), typeof(double), typeof(BreadcrumbItem), new PropertyMetadata());

        public Thickness IconMargin
        {
            get => (Thickness)GetValue(IconMarginProperty);
            set => SetValue(IconMarginProperty, value);
        }

        public static readonly DependencyProperty IconMarginProperty =
            DependencyProperty.Register(nameof(IconMargin), typeof(Thickness), typeof(BreadcrumbItem), new PropertyMetadata());
        
        internal EIcons Kind
        {
            get => (EIcons)GetValue(KindProperty);
            set => SetValue(KindProperty, value);
        }

        internal static readonly DependencyProperty KindProperty =
            DependencyProperty.Register(nameof(Kind), typeof(EIcons), typeof(BreadcrumbItem), new PropertyMetadata());

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register(nameof(Text), typeof(string), typeof(BreadcrumbItem), new PropertyMetadata());

        private void BreadcrumbItem_OnLoaded(object sender, RoutedEventArgs e)
        {
            Type = Type;
        }
    }
}