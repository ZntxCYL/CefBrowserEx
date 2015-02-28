using System;
using System.Windows.Forms;

namespace CefBrowserTest
{
    public partial class FrmRunScript : Form
    {
        private readonly CefBrowserEx.CefBrowserEx cefBrowser;

        public FrmRunScript(CefBrowserEx.CefBrowserEx browser)
        {
            InitializeComponent();
            cefBrowser = browser;
        }

        private void btn_runScript_Click(object sender, EventArgs e)
        {
            cefBrowser.RunScript(tb_script.Text);
        }
    }
}