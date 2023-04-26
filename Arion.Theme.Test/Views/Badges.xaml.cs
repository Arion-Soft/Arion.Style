using System;
using System.Windows;
using System.Windows.Controls;

namespace Arion.Theme.Test.Views
{
    public partial class Badges : UserControl
    {
        public Badges()
        {
            InitializeComponent();
        }

        private void Badge_OnClick(object sender, EventArgs e)
        {
            MessageBox.Show("Success");
        }
    }
}