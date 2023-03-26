using System.Windows;
using System.Windows.Input;

namespace Arion.Style.Controls
{
    public partial class TimeInput
    {
        public TimeInput()
        {
            InitializeComponent();
            Width = 90;
            Height = 40;
            FontSize = 16;
            Margin = new Thickness(10, 6, 10, 6);
        }

        private void Tb1_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (Tb1.Text.Length == 2) Tb2.Focus();
        }

        private void Tb2_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (Tb2.Text.Length == 2) e.Handled = true;
        }

        public int Minute
        {
            get => (int)GetValue(MinuteProperty);
            set => SetValue(MinuteProperty, value);
        }

        public static readonly DependencyProperty MinuteProperty =
            DependencyProperty.Register(nameof(Minute), typeof(int), typeof(TimeInput), new PropertyMetadata());

        public int Second
        {
            get => (int)GetValue(SecondProperty);
            set => SetValue(SecondProperty, value);
        }

        public static readonly DependencyProperty SecondProperty =
            DependencyProperty.Register(nameof(Second), typeof(int), typeof(TimeInput), new PropertyMetadata());

        public string Value
        {
            get => (string)GetValue(ValueProperty);
            set
            {
                if (value.Length > 2 && value.Length <= 4)
                    Second = int.Parse(value.Substring(2));
                else if (value.Length <= 2)
                {
                    if (value == "")
                    {
                        Minute = 0;
                        Second = 0;
                    }
                    else
                    {
                        Minute = int.Parse(value.Substring(0));
                        Second = 0;
                    }
                }
                
                if(value.Length > 4) return;
                SetValue(ValueProperty, value);
            }
        }

        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register(nameof(Value), typeof(string), typeof(TimeInput), new PropertyMetadata());

        public void ClearAll()
        {
            Value = "";
        }

        public void Backspace()
        {
            Value = Value.Length > 0 ? Value.Substring(0, Value.Length - 1) : "";
        }

        public new double Width
        {
            get => (double)GetValue(WidthProperty);
            set => SetValue(WidthProperty, value);
        }

        public new static readonly DependencyProperty WidthProperty =
            DependencyProperty.Register(nameof(Width), typeof(double), typeof(TimeInput), new PropertyMetadata());

        public new double Height
        {
            get => (double)GetValue(HeightProperty);
            set => SetValue(HeightProperty, value);
        }

        public new static readonly DependencyProperty HeightProperty =
            DependencyProperty.Register(nameof(Height), typeof(double), typeof(TimeInput), new PropertyMetadata());

        public new double FontSize
        {
            get => (double)GetValue(FontSizeProperty);
            set => SetValue(FontSizeProperty, value);
        }

        public new static readonly DependencyProperty FontSizeProperty =
            DependencyProperty.Register(nameof(FontSize), typeof(double), typeof(TimeInput), new PropertyMetadata());

        public new Thickness Margin
        {
            get => (Thickness)GetValue(MarginProperty);
            set => SetValue(MarginProperty, value);
        }

        public new static readonly DependencyProperty MarginProperty =
            DependencyProperty.Register(nameof(Margin), typeof(Thickness), typeof(TimeInput), new PropertyMetadata());
    }
}