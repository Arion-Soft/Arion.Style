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
        }

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
                for (int i = 0; i < value.Length; i++) text += '*';
                Tb1.Text = text;
                SetValue(PasswordProperty, value);
            }
        }

        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register(nameof(Password), typeof(string), typeof(PasswordInput),
                new PropertyMetadata(""));

        private void PasswordInput_OnKeyUp(object sender, KeyEventArgs e)
        {
            Password = Tb2.Text;
        }
    }
}