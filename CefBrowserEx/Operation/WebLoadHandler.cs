using Xilium.CefGlue;

namespace CefBrowserEx.Operation
{
    public class WebLoadHandler : CefLoadHandler
    {
        private readonly CefBrowserEx _core;

        public WebLoadHandler(CefBrowserEx core)
        {
            _core = core;
        }

        protected override void OnLoadStart(CefBrowser browser, CefFrame frame)
        {
            if (browser.GetMainFrame().Url == frame.Url)
                _core.LoadStart(browser, frame);
        }

        protected override void OnLoadEnd(CefBrowser browser, CefFrame frame, int httpStatusCode)
        {
            if (httpStatusCode == 200 && browser.GetMainFrame().Url == frame.Url)
            {
                _core.LoadEnd(browser, frame);
            }
        }

        protected override void OnLoadingStateChange(CefBrowser browser, bool isLoading, bool canGoBack, bool canGoForward)
        {
            _core.LoadingStateChange(isLoading, canGoBack, canGoForward);
        }
    }
}