using System.Windows.Forms;

namespace CefBrowserEx.Operation
{
    public partial class IEBrowser : Form
    {
        public IEBrowser()
        {
            InitializeComponent();
        }

        public void Print(string doc)
        {
            webBrowser.DocumentText = doc;
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser.Print();
        }
    }
}