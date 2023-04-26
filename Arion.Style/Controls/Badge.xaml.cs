using System;
using System.Windows;
using System.Windows.Controls;
using Arion.Style.Controls.Enums;

namespace Arion.Style.Controls
{
    public partial class Badge
    {
        public Badge()
        {
            InitializeComponent();
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            var obj = Template.FindName("PART_Button", this);
            if (obj is Button btn) btn.Click += ClickOnBtn_OnClick;
        }

        public event EventHandler Click;

        public new string Content
        {
            get => (string)GetValue(ContentProperty);
            set => SetValue(ContentProperty, value);
        }

        public new static readonly DependencyProperty ContentProperty =
            DependencyProperty.Register(nameof(Content), typeof(string), typeof(Badge), new PropertyMetadata("Badge"));

        public bool ShowButton
        {
            get => (bool)GetValue(ShowButtonProperty);
            set => SetValue(ShowButtonProperty, value);
        }

        public static readonly DependencyProperty ShowButtonProperty =
            DependencyProperty.Register(nameof(ShowButton), typeof(bool), typeof(Badge), new PropertyMetadata(false));

        public bool ShowIcon
        {
            get => (bool)GetValue(ShowIconProperty);
            set => SetValue(ShowIconProperty, value);
        }

        public static readonly DependencyProperty ShowIconProperty =
            DependencyProperty.Register(nameof(ShowIcon), typeof(bool), typeof(Badge), new PropertyMetadata(false));

        public EIcons Icon
        {
            get => (EIcons)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register(nameof(Icon), typeof(EIcons), typeof(Badge), new PropertyMetadata(EIcons.Folder));

        public EIcons ButtonIcon
        {
            get => (EIcons)GetValue(ButtonIconProperty);
            set => SetValue(ButtonIconProperty, value);
        }

        public static readonly DependencyProperty ButtonIconProperty =
            DependencyProperty.Register(nameof(ButtonIcon), typeof(EIcons), typeof(Badge), new PropertyMetadata(EIcons.Close));

        public BadgeColor Color
        {
            get => (BadgeColor)GetValue(ColorProperty);
            set => SetValue(ColorProperty, value);
        }

        public static readonly DependencyProperty ColorProperty =
            DependencyProperty.Register(nameof(Color), typeof(BadgeColor), typeof(Badge), new PropertyMetadata(BadgeColor.White));

        public BadgeType Type
        {
            get => (BadgeType)GetValue(TypeProperty);
            set => SetValue(TypeProperty, value);
        }

        public static readonly DependencyProperty TypeProperty =
            DependencyProperty.Register(nameof(Type), typeof(BadgeType), typeof(Badge), new PropertyMetadata(BadgeType.Filled));
        
        private void ClickOnBtn_OnClick(object sender, RoutedEventArgs e)
        {
            Click?.Invoke(this, EventArgs.Empty);
        }
    }
}