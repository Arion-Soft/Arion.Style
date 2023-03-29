using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Arion.Style.Controls
{
    /// <summary>
    /// Логика взаимодействия для OptionControl.xaml
    /// </summary>
    public partial class OptionControl
    {
        public string Caption
        {
            get => (string)GetValue(CaptionProperty);
            set => SetValue(CaptionProperty, value);
        }

        private static readonly DependencyProperty CaptionProperty =
            DependencyProperty.Register(nameof(Caption), typeof(string), typeof(OptionControl), new PropertyMetadata());

        public bool IsChecked
        {
            get => (bool)GetValue(IsCheckedProperty);
            set => SetValue(IsCheckedProperty, value);
        }

        private static readonly DependencyProperty IsCheckedProperty =
            DependencyProperty.Register(nameof(IsChecked), typeof(bool), typeof(OptionControl), new PropertyMetadata());

        public OptionControl()
        {
            InitializeComponent();
        }

        private void UIElement_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            IsChecked = !IsChecked;
        }

        private void Tg_OnChecked(object sender, RoutedEventArgs e)
        {
            Border.Background = new SolidColorBrush(Color.FromRgb(0xF6, 0xF8, 0xF9));
        }

        private void Tg_OnUnchecked(object sender, RoutedEventArgs e)
        {
            Border.Background = new SolidColorBrush(Color.FromRgb(0xD5, 0xDA, 0xDD));
        }
    }
}