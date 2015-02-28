using System.ComponentModel;
using Xilium.CefGlue;

namespace CefBrowserEx
{
    /// <summary>
    /// 浏览器创建新窗口前事件委托
    /// </summary>
    public delegate void NewWindowEventHandler(string targetUrl, CancelEventArgs e);

    /// <summary>
    /// 标题更改事件委托
    /// </summary>
    public delegate void TitleChangedEventHandler(string title);

    /// <summary>
    /// 地址更改事件委托
    /// </summary>
    public delegate void AddressChangedEventHandler(string url);

    /// <summary>
    /// 目标Url更改事件委托
    /// </summary>
    public delegate void TargetUrlChangedEventHandler(string value);

    /// <summary>
    /// 加载事件委托
    /// </summary>
    public delegate void LoadEventHandler(CefBrowser browser, CefFrame frame);

    /// <summary>
    /// 加载状态更改事件委托
    /// </summary>
    public delegate void LoadingStateChangeEventHandler(bool isLoading, bool canGoBack, bool canGoForward);
}