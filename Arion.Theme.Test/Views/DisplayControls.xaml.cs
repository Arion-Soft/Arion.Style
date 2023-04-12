using System;
using System.Windows.Controls;

namespace Arion.Theme.Test.Views
{
    public partial class DisplayControls : UserControl
    {
        public DisplayControls()
        {
            InitializeComponent();
        }
        
        private void DisplayControlFull_OnTargetValueChange(object sender, EventArgs e)
        {
            // MessageBox.Show("Change");
        }
    }
}