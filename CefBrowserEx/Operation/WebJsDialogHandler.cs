using System.Windows.Forms;
using Xilium.CefGlue;

namespace CefBrowserEx.Operation
{
    public class WebJsDialogHandler : CefJSDialogHandler
    {
        protected override bool OnJSDialog(CefBrowser browser, string originUrl, string acceptLang,
            CefJSDialogType dialogType, string message_text, string default_prompt_text,
            CefJSDialogCallback callback, out bool suppress_message)
        {
            switch (dialogType)
            {
                case CefJSDialogType.Alert:
                    if (message_text.StartsWith("$Print$"))
                    {
                        var str = message_text.Substring(7);
                        var ieb = new IEBrowser();
                        ieb.Print(str);
                        ieb.Show();
                        suppress_message = true;
                        return false;
                    }
                    MessageBox.Show(message_text, "系统提示");
                    suppress_message = true;
                    return false;
                case CefJSDialogType.Confirm:
                    var dr = MessageBox.Show(message_text, "系统提示", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        callback.Continue(true, string.Empty);
                        suppress_message = false;
                        return true;
                    }
                    callback.Continue(false, string.Empty);
                    suppress_message = false;
                    return true;
                case CefJSDialogType.Prompt:
                    MessageBox.Show("系统不支持prompt形式的提示框", "UTMP系统提示");
                    break;
            }
            suppress_message = true;
            return false;
        }

        protected override bool OnBeforeUnloadDialog(CefBrowser browser, string messageText, bool isReload, CefJSDialogCallback callback)
        {
            return false;
        }

        protected override void OnResetDialogState(CefBrowser browser)
        {
        }

        protected override void OnDialogClosed(CefBrowser browser)
        {
        }
    }
}