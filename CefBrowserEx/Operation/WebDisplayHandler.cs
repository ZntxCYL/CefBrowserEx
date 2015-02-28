using System;
using Xilium.CefGlue;

namespace CefBrowserEx.Operation
{
    internal sealed class WebDisplayHandler : CefDisplayHandler
    {
        private readonly CefBrowserEx _core;

        public WebDisplayHandler(CefBrowserEx core)
        {
            _core = core;
        }

        protected override void OnTitleChange(CefBrowser browser, string title)
        {
            _core.TitleChanged(title);
        }

        protected override void OnAddressChange(CefBrowser browser, CefFrame frame, string url)
        {
            if (frame.IsMain)
            {
                _core.AddressChanged(url);
            }
        }

        protected override void OnStatusMessage(CefBrowser browser, string value)
        {
            _core.TargetUrlChanged(value);
        }

        protected override bool OnTooltip(CefBrowser browser, string text)
        {
            Console.WriteLine("OnTooltip: {0}", text);
            return false;
        }
    }
}