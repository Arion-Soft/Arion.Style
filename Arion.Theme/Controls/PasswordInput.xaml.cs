using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Arion.Theme.Controls
{
    public partial class PasswordInput : UserControl
    {
        public PasswordInput()
        {
            InitializeComponent();
            Width = 200;
            Height = 40;
            FontSize = 14;
        }

        public event EventHandler PasswordChanged;

        public string Placeholder
        {
            get => (string)GetValue(PlaceholderProperty);
            set => SetValue(PlaceholderProperty, value);
        }

        public static readonly DependencyProperty PlaceholderProperty =
            DependencyProperty.Register(nameof(Placeholder), typeof(string), typeof(PasswordInput),
                new PropertyMetadata(""));

        public string Password
        {
            get => (string)GetValue(PasswordProperty);
            set
            {
                var text = "";
                for (int i = 0; i < value.Length; i++) text += '\u25CF';
                Tb1.Text = text;
                PasswordChanged?.Invoke(null, null);
                SetValue(PasswordProperty, value);
            }
        }

        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register(nameof(Password), typeof(string), typeof(PasswordInput),
                new PropertyMetadata(""));

        public new double Width
        {
            get => (double)GetValue(WidthProperty);
            set => SetValue(WidthProperty, value);
        }

        public new static readonly DependencyProperty WidthProperty =
            DependencyProperty.Register(nameof(Width), typeof(double), typeof(PasswordInput), new PropertyMetadata());

        public new double Height
        {
            get => (double)GetValue(HeightProperty);
            set => SetValue(HeightProperty, value);
        }

        public new static readonly DependencyProperty HeightProperty =
            DependencyProperty.Register(nameof(Height), typeof(double), typeof(PasswordInput), new PropertyMetadata());

        public new int FontSize
        {
            get => (int)GetValue(FontSizeProperty);
            set => SetValue(FontSizeProperty, value);
        }

        public new static readonly DependencyProperty FontSizeProperty =
            DependencyProperty.Register(nameof(FontSize), typeof(int), typeof(PasswordInput), new PropertyMetadata());
        
        private void PasswordInput_OnKeyUp(object sender, KeyEventArgs e)
        {
            Password = Tb2.Text;
        }
    }
}