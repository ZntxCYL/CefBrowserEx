using Xilium.CefGlue;

namespace CefBrowserEx.Operation
{
    public class WebContextMenuHandler : CefContextMenuHandler
    {
        private readonly CefBrowserEx _core;

        public WebContextMenuHandler(CefBrowserEx core)
        {
            _core = core;
        }

        protected override void OnBeforeContextMenu(CefBrowser browser, CefFrame frame, CefContextMenuParams state, CefMenuModel model)
        {
            if (!_core.IsEnabledContextMenu)
                model.Clear();
        }
    }
}