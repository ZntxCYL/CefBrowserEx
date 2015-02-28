using System.ComponentModel;
using Xilium.CefGlue;

namespace CefBrowserEx.Operation
{
    public class WebLifeSpanHandler : CefLifeSpanHandler
    {
        private readonly CefBrowserEx _core;

        public WebLifeSpanHandler(CefBrowserEx core)
        {
            _core = core;
        }

        protected override bool OnBeforePopup(CefBrowser browser, CefFrame frame, string targetUrl, string targetFrameName,
            CefPopupFeatures popupFeatures, CefWindowInfo windowInfo, ref CefClient client, CefBrowserSettings settings,
            ref bool noJavascriptAccess)
        {
            var e = new CancelEventArgs();
            _core.NewWindow(targetUrl, e);
            return e.Cancel;
        }

        /// <summary>
        /// 浏览器窗口创建成功后的事件
        /// </summary>
        protected override void OnAfterCreated(CefBrowser browser)
        {
            base.OnAfterCreated(browser);
            _core.OnCreated(browser);
        }
    }
}