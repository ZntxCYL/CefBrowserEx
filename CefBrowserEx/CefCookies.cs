using System.Collections.Generic;
using Xilium.CefGlue;

namespace CefBrowserEx
{
    /// <summary>
    /// Cookie集合
    /// </summary>
    public class CefCookies : CefCookieVisitor
    {
        private readonly List<CefCookie> cefCookieCollection = new List<CefCookie>();

        /// <summary>
        /// Cookie集合
        /// </summary>
        public List<CefCookie> CefCookieCollection
        {
            get { return cefCookieCollection; }
        }

        protected override bool Visit(CefCookie cookie, int count, int total, out bool delete)
        {
            delete = false;
            cefCookieCollection.Add(cookie);
            return true;
        }
    }
}