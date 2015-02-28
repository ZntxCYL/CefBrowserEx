using System.Windows.Forms;

namespace CefBrowserTest
{
    public partial class FrmBrowser : Form
    {
        public FrmBrowser()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 返回
        /// </summary>
        private void btn_back_Click(object sender, System.EventArgs e)
        {
            cefBrowserEx.GoBack();
        }

        /// <summary>
        /// 前进
        /// </summary>
        private void btn_forward_Click(object sender, System.EventArgs e)
        {
            cefBrowserEx.GoForward();
        }

        /// <summary>
        /// 刷新
        /// </summary>
        private void btn_refresh_Click(object sender, System.EventArgs e)
        {
            cefBrowserEx.Reload();
        }

        /// <summary>
        /// 停止
        /// </summary>
        private void btn_stop_Click(object sender, System.EventArgs e)
        {
            cefBrowserEx.Stop();
        }

        /// <summary>
        /// 访问
        /// </summary>
        private void btn_go_Click(object sender, System.EventArgs e)
        {
            cefBrowserEx.Navigate(tb_url.Text);
        }

        /// <summary>
        /// 创建新窗口前事件
        /// </summary>
        private void cefBrowserEx_OnNewWindow(string targetUrl, System.ComponentModel.CancelEventArgs e)
        {
            cefBrowserEx.Navigate(targetUrl);
            e.Cancel = true;
        }

        /// <summary>
        /// 开始加载事件
        /// </summary>
        private void cefBrowserEx_LoadStartEvent(Xilium.CefGlue.CefBrowser browser, Xilium.CefGlue.CefFrame frame)
        {
            Invoke(new Action(() => tb_url.Text = frame.Url));
        }

        /// <summary>
        /// 加载结束事件
        /// </summary>
        private void cefBrowserEx_LoadEndEvent(Xilium.CefGlue.CefBrowser browser, Xilium.CefGlue.CefFrame frame)
        {
            Invoke(new Action(() => tb_url.Text = frame.Url));
        }

        /// <summary>
        /// 加载状态更改事件
        /// </summary>
        private void cefBrowserEx_OnLoadingStateChange(bool isLoading, bool canGoBack, bool canGoForward)
        {
            Invoke(new Action(() =>
            {
                btn_back.Enabled = canGoBack;
                btn_forward.Enabled = canGoForward;
            }));
        }

        /// <summary>
        /// 地址栏按下回车键
        /// </summary>
        private void tb_url_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                cefBrowserEx.Navigate(tb_url.Text);
            }
        }

        /// <summary>
        /// 查看源代码
        /// </summary>
        private void btn_viewCode_Click(object sender, System.EventArgs e)
        {
            cefBrowserEx.CefBrowser.GetMainFrame().ViewSource();
        }

        private FrmRunScript formRunScript;
        /// <summary>
        /// 执行JavaScript
        /// </summary>
        private void btn_runScript_Click(object sender, System.EventArgs e)
        {
            if (formRunScript == null || formRunScript.IsDisposed || !formRunScript.IsHandleCreated)
            {
                formRunScript = new FrmRunScript(cefBrowserEx);
            }
            formRunScript.Activate();
            formRunScript.Show();
        }
    }

    public delegate void Action();
}