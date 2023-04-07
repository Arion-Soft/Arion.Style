using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Effects;
using Arion.Style.Controls.Enums;

namespace Arion.Style.Controls
{
    public partial class ModalDialog
    {
        private static ModalDialog _modalDialog;
        private ModalDialogResult _result;
        public ModalDialog(string message, string caption, ModalDialogButtons buttons, ModalDialogType type)
        {
            InitializeComponent();

            Message = message;
            Caption = caption;
            Buttons = buttons;
            Type = type;
            
            switch(Buttons)
            {
                case ModalDialogButtons.Ok:
                {
                    BtnOk.Visibility = Visibility.Visible;
                    BtnYes.Visibility = Visibility.Collapsed;
                    BtnNo.Visibility = Visibility.Collapsed;
                    BtnCancel.Visibility = Visibility.Collapsed;
                    break;
                }
                case ModalDialogButtons.Yes:
                {
                    BtnOk.Visibility = Visibility.Collapsed;
                    BtnYes.Visibility = Visibility.Visible;
                    BtnNo.Visibility = Visibility.Collapsed;
                    BtnCancel.Visibility = Visibility.Collapsed;
                    break;
                }
                case ModalDialogButtons.YesNo:
                {
                    BtnOk.Visibility = Visibility.Collapsed;
                    BtnYes.Visibility = Visibility.Visible;
                    BtnNo.Visibility = Visibility.Visible;
                    BtnCancel.Visibility = Visibility.Collapsed;
                    break;
                }
                case ModalDialogButtons.No:
                {
                    BtnOk.Visibility = Visibility.Collapsed;
                    BtnYes.Visibility = Visibility.Collapsed;
                    BtnNo.Visibility = Visibility.Visible;
                    BtnCancel.Visibility = Visibility.Collapsed;
                    break;
                }
                case ModalDialogButtons.Cancel:
                {
                    BtnOk.Visibility = Visibility.Collapsed;
                    BtnYes.Visibility = Visibility.Collapsed;
                    BtnNo.Visibility = Visibility.Collapsed;
                    BtnCancel.Visibility = Visibility.Visible;
                    break;
                }
                case ModalDialogButtons.OkCancel:
                {
                    BtnOk.Visibility = Visibility.Visible;
                    BtnYes.Visibility = Visibility.Collapsed;
                    BtnNo.Visibility = Visibility.Collapsed;
                    BtnCancel.Visibility = Visibility.Visible;
                    break;
                }
            }

            switch (Type)
            {
                case ModalDialogType.Info:
                {
                    ModalIcon = EIcons.InfoCircle;
                    ModalIconColor = new SolidColorBrush(Color.FromRgb(0x40, 0x94, 0xF7));
                    break;
                }
                case ModalDialogType.Danger:
                {
                    ModalIcon = EIcons.Alert;
                    ModalIconColor = new SolidColorBrush(Color.FromRgb(0xF7, 0x66, 0x59));
                    break;
                }
                case ModalDialogType.Warning:
                {
                    ModalIcon = EIcons.Alert;
                    ModalIconColor = new SolidColorBrush(Color.FromRgb(0xF8, 0xC5, 0x1B));
                    break;
                }
                case ModalDialogType.Success:
                {
                    ModalIcon = EIcons.SuccessCircle;
                    ModalIconColor = new SolidColorBrush(Color.FromRgb(0x47, 0xD1, 0x6C));
                    break;
                }
                case ModalDialogType.NoIcon:
                {
                    ModalIconVisibility = Visibility.Collapsed;
                    break;
                }
            }
        }

        public static ModalDialogResult Show( string caption, string message = "", ModalDialogButtons buttons = ModalDialogButtons.Ok, ModalDialogType type = ModalDialogType.Info,
            Window windowForBlur = null)
        {
            _modalDialog = new ModalDialog (message, caption, buttons, type);
            if (windowForBlur != null) windowForBlur.Effect = new BlurEffect { Radius = 3 };
            _modalDialog.ShowDialog();
            if (windowForBlur != null) windowForBlur.Effect = new BlurEffect { Radius = 0 };
            return _modalDialog._result;
        }

        public EIcons ModalIcon
        {
            get => (EIcons)GetValue(ModalIconProperty);
            set => SetValue(ModalIconProperty, value);
        }

        public static readonly DependencyProperty ModalIconProperty =
            DependencyProperty.Register(nameof(ModalIcon), typeof(EIcons), typeof(ModalDialog), new PropertyMetadata());

        public SolidColorBrush ModalIconColor
        {
            get => (SolidColorBrush)GetValue(ModalIconColorProperty);
            set => SetValue(ModalIconColorProperty, value);
        }

        public static readonly DependencyProperty ModalIconColorProperty =
            DependencyProperty.Register(nameof(ModalIconColor), typeof(SolidColorBrush), typeof(ModalDialog), new PropertyMetadata());

        public Visibility ModalIconVisibility
        {
            get => (Visibility)GetValue(ModalIconVisibilityProperty);
            set => SetValue(ModalIconVisibilityProperty, value);
        }

        public static readonly DependencyProperty ModalIconVisibilityProperty =
            DependencyProperty.Register(nameof(ModalIconVisibility), typeof(Visibility), typeof(ModalDialog), new PropertyMetadata(Visibility.Visible));
        
        public string Caption
        {
            get => (string)GetValue(CaptionProperty);
            set => SetValue(CaptionProperty, value);
        }

        public static readonly DependencyProperty CaptionProperty =
            DependencyProperty.Register(nameof(Caption), typeof(string), typeof(ModalDialog), new PropertyMetadata("Caption"));

        public string Message
        {
            get => (string)GetValue(MessageProperty);
            set => SetValue(MessageProperty, value);
        }

        public static readonly DependencyProperty MessageProperty =
            DependencyProperty.Register(nameof(Message), typeof(string), typeof(ModalDialog), new PropertyMetadata("Message"));

        public ModalDialogType Type
        {
            get => (ModalDialogType)GetValue(TypeProperty);
            set => SetValue(TypeProperty, value);
        }

        public static readonly DependencyProperty TypeProperty =
            DependencyProperty.Register(nameof(Type), typeof(ModalDialogType), typeof(ModalDialog), new PropertyMetadata());

        public ModalDialogButtons Buttons
        {
            get => (ModalDialogButtons)GetValue(ButtonsProperty);
            set => SetValue(ButtonsProperty, value);
        }

        public static readonly DependencyProperty ButtonsProperty =
            DependencyProperty.Register(nameof(Buttons), typeof(ModalDialogButtons), typeof(ModalDialog), new PropertyMetadata());

        private void BtnClose_OnClick(object sender, RoutedEventArgs e)
        {
            _result = ModalDialogResult.Cancel;
            Close();
        }

        private void BtnOk_OnClick(object sender, RoutedEventArgs e)
        {
            _result = ModalDialogResult.Ok;
            Close();
        }

        private void BtnYes_OnClick(object sender, RoutedEventArgs e)
        {
            _result = ModalDialogResult.Yes;
            Close();
        }

        private void BtnNo_OnClick(object sender, RoutedEventArgs e)
        {
            _result = ModalDialogResult.No;
            Close();
        }

        private void BtnCancel_OnClick(object sender, RoutedEventArgs e)
        {
            _result = ModalDialogResult.Cancel;
            Close();
        }
    }
}