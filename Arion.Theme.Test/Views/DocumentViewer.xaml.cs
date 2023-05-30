using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Xps.Packaging;

namespace Arion.Theme.Test.Views
{
    public partial class DocumentViewer : UserControl
    {
        public DocumentViewer()
        {
            InitializeComponent();
        }

        private void DocumentViewer_OnLoaded(object sender, RoutedEventArgs e)
        {
            // string fileName = null;
            // string appPath = System.IO.Path.GetDirectoryName(Assembly.GetAssembly(typeof(App)).CodeBase);
            // fileName = appPath + @"\Files\Instruction.xps";
            // fileName = fileName.Remove(0, 6);
            // XpsDocument doc = new XpsDocument(fileName, FileAccess.Read);
            // DcViewer.Document = doc.GetFixedDocumentSequence();
        }
    }
}