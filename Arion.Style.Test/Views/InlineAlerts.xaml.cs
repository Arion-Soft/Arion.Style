using System;
using System.Windows.Controls;
using Arion.Style.Controls;

namespace Arion.Theme.Test.Views
{
    public partial class InlineAlerts : UserControl
    {
        public InlineAlerts()
        {
            InitializeComponent();
        }
        
        private void InlineAlert_OnPrimaryClick(object sender, EventArgs e)
        {
            ModalDialog.Show("", "Click to InlineAlert PRIMARY BUTTON");
        }

        private void InlineAlert_OnSecondaryClick(object sender, EventArgs e)
        {
            ModalDialog.Show("","Click to InlineAlert SECONDARY BUTTON");
        }
    }
}