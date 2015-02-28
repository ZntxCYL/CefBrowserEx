using Xilium.CefGlue;

namespace CefBrowserEx.Operation
{
    public class WebClient : CefClient
    {
        private readonly CefLifeSpanHandler lifeSpanHandler;
        private readonly CefDownloadHandler downloadHandler;
        private readonly CefJSDialogHandler jsDialogHandler;
        private readonly CefContextMenuHandler contextMenuHandler;
        private readonly CefLoadHandler loadHandler;
        private readonly CefDisplayHandler displayHandler;

        public WebClient(CefBrowserEx core)
        {
            lifeSpanHandler = new WebLifeSpanHandler(core);
            downloadHandler = new WebDownloadHandler();
            jsDialogHandler = new WebJsDialogHandler();
            contextMenuHandler = new WebContextMenuHandler(core);
            loadHandler = new WebLoadHandler(core);
            displayHandler = new WebDisplayHandler(core);
        }

        protected override CefLoadHandler GetLoadHandler()
        {
            return loadHandler;
        }

        protected override CefLifeSpanHandler GetLifeSpanHandler()
        {
            return lifeSpanHandler;
        }

        protected override CefDownloadHandler GetDownloadHandler()
        {
            return downloadHandler;
        }

        protected override CefJSDialogHandler GetJSDialogHandler()
        {
            return jsDialogHandler;
        }

        protected override CefContextMenuHandler GetContextMenuHandler()
        {
            return contextMenuHandler;
        }

        protected override CefDisplayHandler GetDisplayHandler()
        {
            return displayHandler;
        }
    }
}