using System.Windows.Controls;
using System.Windows.Input;

namespace Arion.Theme.Controls
{
    public partial class TimeInput : UserControl
    {
        public TimeInput()
        {
            InitializeComponent();
        }

        private void Tb1_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (Tb1.Text.Length == 2) Tb2.Focus();
        }

        private void Tb2_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (Tb2.Text.Length == 2) e.Handled = true;
        }
    }
}