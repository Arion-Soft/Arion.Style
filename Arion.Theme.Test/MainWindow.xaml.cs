using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Arion.Style.Controls;
using Arion.Style.AttachedProperties;
using Arion.Style.Controls.Enums;
using Button = Arion.Style.AttachedProperties.Button;
using Clipboard = System.Windows.Clipboard;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Arion.Theme.Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            
        }

        private void BtnProgress_OnClick(object sender, RoutedEventArgs e)
        {
            // Button.SetIcon(BtnTest, EIcons.NULL);
            // Button.SetProgressBarMaximum(BtnTest, 100);
            // Button.SetProgressBarMinimum(BtnTest, 0);
            // Button.SetProgressBarShow(BtnTest, true);
            // Button.SetProgressBarType(BtnTest, ProgressBarType.Circle);
            // Button.SetProgressBarValue(BtnTest, 50);
        }

        private void DisplayControlFull_OnTargetValueChange(object sender, EventArgs e)
        {
            // MessageBox.Show("Change");
        }

        private void BtnTest_OnClick(object sender, RoutedEventArgs e)
        {
            // BtnTest.Foreground = new SolidColorBrush(Colors.Red);
            // BtnTest2.Foreground = new SolidColorBrush(Colors.Red);
            // BtnTest3.Foreground = new SolidColorBrush(Colors.Red);
        }

        

        private void BtnOpenModalInfo_OnClick(object sender, RoutedEventArgs e)
        {
            ModalDialog.Show(
                "Modal dialog more info for test size caption",
                "A modal dialog is a dialog that appears on top of the main content and moves the system into a special mode requiring user interaction.");
        }

        private void BtnOpenModalDanger_OnClick(object sender, RoutedEventArgs e)
        {
            ModalDialog.Show(
                "Modal dialog",
                "A modal dialog is a dialog that appears on top of the main content and moves the system into a special mode requiring user interaction.",
                 ModalDialogButtons.Ok, ModalDialogType.Danger);
        }

        private void BtnOpenModalWarning_OnClick(object sender, RoutedEventArgs e)
        {
            ModalDialog.Show(
                "Modal dialog",
                "A modal dialog is a dialog that appears on top of the main content and moves the system into a special mode requiring user interaction.",
                ModalDialogButtons.Ok, ModalDialogType.Warning, this);
        }

        private void BtnOpenModalSuccess_OnClick(object sender, RoutedEventArgs e)
        {
            ModalDialog.Show(
                "Modal dialog",
                "A modal dialog is a dialog that appears on top of the main content and moves the system into a special mode requiring user interaction.",
                 ModalDialogButtons.Ok, ModalDialogType.Success);
        }

        private void BtnOpenModalNoIcon_OnClick(object sender, RoutedEventArgs e)
        {
            ModalDialog.Show(
                "Modal dialog",
                "A modal dialog is a dialog that appears on top of the main content and moves the system into a special mode requiring user interaction.",
                 ModalDialogButtons.Ok, ModalDialogType.NoIcon);
        }
    }
}