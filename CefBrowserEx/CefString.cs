using Xilium.CefGlue;

namespace CefBrowserEx
{
    /// <summary>
    /// 字符串
    /// </summary>
    public class CefString : CefStringVisitor
    {
        private string returnValue;

        /// <summary>
        /// 返回的值
        /// </summary>
        public string Value
        {
            get { return returnValue; }
        }

        protected override void Visit(string value)
        {
            returnValue = value;
        }
    }
}