using System;
using System.Windows.Forms;

namespace CefBrowserTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cefBrowserEx_LoadStartEvent(Xilium.CefGlue.CefBrowser browser, Xilium.CefGlue.CefFrame frame)
        {
            Console.WriteLine(frame.Url);
        }

        private void cefBrowserEx_LoadEndEvent(Xilium.CefGlue.CefBrowser browser, Xilium.CefGlue.CefFrame frame)
        {
            Console.WriteLine("over");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cefBrowserEx.RunScript("function openBaiDu()\r\n{\r\n    window.open(\'http://www.baidu.com/\', \'BaiDu\');\r\n}\r\no" +
    "penBaiDu()");
        }
    }
}