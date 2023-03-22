using System;
using System.Windows;
using System.Windows.Media;
using Arion.Style.Controls.Enums;

namespace Arion.Style.Controls
{
    public partial class InlineAlert
    {
        private ResourceDictionary _styles;
        public InlineAlert()
        {
            InitializeComponent();
            _styles = new ResourceDictionary
            {
                Source = new Uri("/Arion.Theme;component/ArionUiTheme.xaml",
                    UriKind.RelativeOrAbsolute)
            };
        }

        #region Events

        public event EventHandler CaptionChanged;
        public event EventHandler MessageChanged;
        public event EventHandler TypeChanged;

        #endregion

        #region Properties

        #region Caption

        public string Caption
        {
            get => (string)GetValue(CaptionProperty);
            set
            {
                SetValue(CaptionProperty, value);
                CaptionChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public static readonly DependencyProperty CaptionProperty =
            DependencyProperty.Register(nameof(Caption), typeof(string), typeof(InlineAlert), new PropertyMetadata());

        #endregion

        #region Message

        public string Message
        {
            get => (string)GetValue(MessageProperty);
            set
            {
                SetValue(MessageProperty, value);
                MessageChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public static readonly DependencyProperty MessageProperty =
            DependencyProperty.Register(nameof(Message), typeof(string), typeof(InlineAlert), new PropertyMetadata());

        #endregion

        public SolidColorBrush ColorIcon
        {
            get => (SolidColorBrush)GetValue(ColorIconProperty);
            set => SetValue(ColorIconProperty, value);
        }

        public static readonly DependencyProperty ColorIconProperty =
            DependencyProperty.Register(nameof(ColorIcon), typeof(SolidColorBrush), typeof(InlineAlert), new PropertyMetadata());

        public EIcons Icon
        {
            get => (EIcons)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register(nameof(Icon), typeof(EIcons), typeof(InlineAlert), new PropertyMetadata());
        
        #region Type

        public InlineAlertType Type
        {
            get => (InlineAlertType)GetValue(TypeProperty);
            set
            {
                if (value == InlineAlertType.Info)
                {
                    BrdMain.Background = (SolidColorBrush)_styles["Pr100"];
                    BrdMain.BorderBrush = (SolidColorBrush)_styles["Pr200"];
                    Primary.Style = (System.Windows.Style)_styles["InlineAlertInfoPrimary"];
                    ColorIcon = (SolidColorBrush)_styles["Pr500"];
                    Icon = EIcons.InfoCircle;
                }
                else if (value == InlineAlertType.Danger)
                {
                    BrdMain.Background = (SolidColorBrush)_styles["R100"];
                    BrdMain.BorderBrush = (SolidColorBrush)_styles["R200"];
                    Primary.Style = (System.Windows.Style)_styles["InlineAlertDangerPrimary"];
                    ColorIcon = (SolidColorBrush)_styles["R500"];
                    Icon = EIcons.Alert;
                }
                else if (value == InlineAlertType.Warning)
                {
                    BrdMain.Background = (SolidColorBrush)_styles["Y100"];
                    BrdMain.BorderBrush = (SolidColorBrush)_styles["Y300"];
                    Primary.Style = (System.Windows.Style)_styles["InlineAlertWarningPrimary"];
                    ColorIcon = (SolidColorBrush)_styles["Y500"];
                    Icon = EIcons.Alert;
                }
                else if (value == InlineAlertType.Success)
                {
                    BrdMain.Background = (SolidColorBrush)_styles["G100"];
                    BrdMain.BorderBrush = (SolidColorBrush)_styles["G200"];
                    Primary.Style = (System.Windows.Style)_styles["InlineAlertSuccessPrimary"];
                    ColorIcon = (SolidColorBrush)_styles["G500"];
                    Icon = EIcons.Success;
                }
                SetValue(TypeProperty, value);
                TypeChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public static readonly DependencyProperty TypeProperty =
            DependencyProperty.Register(nameof(Type), typeof(InlineAlertType), typeof(InlineAlert), new PropertyMetadata());

        #endregion

        #endregion


        private void InlineAlert_OnLoaded(object sender, RoutedEventArgs e)
        {
            Type = Type;
        }
    }
}