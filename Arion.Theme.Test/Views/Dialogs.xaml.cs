using System.Threading;
using System.Windows;
using System.Windows.Controls;
using Arion.Style.Controls;

namespace Arion.Theme.Test.Views
{
    public partial class Dialogs : UserControl
    {
        public Dialogs()
        {
            InitializeComponent();
        }

        private void BtnOpenModalDialogInOtherThread_Onclick(object sender, RoutedEventArgs e)
        {
            new Thread(() =>
            {
                ModalDialog.Show("Уведомление", "Внимание\nВы уведомлены!");
            }).Start();
        }
        
        private void BtnOpenModalDialogInCurrentThread_Onclick(object sender, RoutedEventArgs e)
        {
            ModalDialog.Show("Уведомление", "Внимание\nВы уведомлены!");
        }
    }
}