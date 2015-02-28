using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using CefBrowserEx.Operation;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using Xilium.CefGlue;

namespace CefBrowserEx
{
    /// <summary>
    /// 浏览器控件
    /// </summary>
    [ToolboxBitmap(typeof(WebBrowser))]
    public class CefBrowserEx : UserControl
    {
        #region 初始化

        public CefBrowserEx()
        {
            InitializeControl();
            InitializeEvents();
            InitializeBrowser();
        }

        /// <summary>
        /// 初始化控件
        /// </summary>
        private void InitializeControl()
        {
            SetStyle(
                ControlStyles.ContainerControl
                | ControlStyles.ResizeRedraw
                | ControlStyles.FixedWidth
                | ControlStyles.FixedHeight
                | ControlStyles.StandardClick
                | ControlStyles.UserMouse
                | ControlStyles.SupportsTransparentBackColor
                | ControlStyles.StandardDoubleClick
                | ControlStyles.OptimizedDoubleBuffer
                | ControlStyles.CacheText
                | ControlStyles.EnableNotifyMessage
                | ControlStyles.DoubleBuffer
                | ControlStyles.OptimizedDoubleBuffer
                | ControlStyles.UseTextForAccessibility
                | ControlStyles.Opaque,
                false);

            SetStyle(
                ControlStyles.UserPaint
                | ControlStyles.AllPaintingInWmPaint
                | ControlStyles.Selectable,
                true);

            Dock = DockStyle.Fill;
        }

        /// <summary>
        /// 初始化事件
        /// </summary>
        private void InitializeEvents()
        {
            Load += CefBrowserEx_Load;
            Application.ThreadExit += Application_ThreadExit;
        }

        /// <summary>
        /// 初始化浏览器
        /// </summary>
        private void InitializeBrowser()
        {
            if (IsDesignMode())
                return;
            CefRuntime.Load(ConfigurationManager.AppSettings["CefLibraryPath"]);
            var mainArgs = new CefMainArgs(new string[] { });
            var cefApp = new WebApp();
            var exitCode = CefRuntime.ExecuteProcess(mainArgs, cefApp, IntPtr.Zero);
            if (exitCode != -1)
                return;
            var settings = new CefSettings
            {
                SingleProcess = false,
                MultiThreadedMessageLoop = true,
                LogSeverity = CefLogSeverity.Disable,
                Locale = "zh-CN"
            };
            CefRuntime.Initialize(mainArgs, settings, cefApp, IntPtr.Zero);
            if (!settings.MultiThreadedMessageLoop)
            {
                Application.Idle += (sender, e) => CefRuntime.DoMessageLoopWork();
            }
        }

        #endregion

        #region 字段

        private bool isEnabledContextMenu = true;
        private bool justGetCurrentCookie = true;
        private CefCookies cefCookies;
        private CefString documentText;

        #endregion

        #region 属性

        /// <summary>
        /// 启动时跳转到的网址
        /// </summary>
        [Category("行为"), Description("启动时跳转到的网址")]
        public string Url { get; set; }

        /// <summary>
        /// 是否启用右键菜单
        /// </summary>
        [Category("行为"), Description("是否启用右键菜单"), DefaultValue(true)]
        public bool IsEnabledContextMenu
        {
            get { return isEnabledContextMenu; }
            set { isEnabledContextMenu = value; }
        }

        /// <summary>
        /// 只获取当前页面的Cookie(否则获取所有访问过页面的Cookie)
        /// </summary>
        [Category("行为"), Description("只获取当前页面的Cookie(否则获取所有访问过页面的Cookie)"), DefaultValue(true)]
        public bool JustGetCurrentCookie
        {
            get { return justGetCurrentCookie; }
            set { justGetCurrentCookie = value; }
        }

        /// <summary>
        /// CEF浏览器核心
        /// </summary>
        [Browsable(false)]
        public CefBrowser CefBrowser { get; private set; }

        /// <summary>
        /// 是否可以前进
        /// </summary>
        [Browsable(false)]
        public bool CanGoForward
        {
            get { return CefBrowser.CanGoForward; }
        }

        /// <summary>
        /// 是否可以后退
        /// </summary>
        [Browsable(false)]
        public bool CanGoBack
        {
            get { return CefBrowser.CanGoBack; }
        }

        /// <summary>
        /// Cookie集合
        /// </summary>
        [Browsable(false)]
        public List<CefCookie> CookieCollection
        {
            get { return cefCookies.CefCookieCollection; }
        }

        /// <summary>
        /// 当前页面内容
        /// </summary>
        [Browsable(false)]
        public string DocumentText
        {
            get { return documentText.Value; }
        }

        #endregion

        #region 事件

        /// <summary>
        /// 浏览器创建新窗口前事件
        /// </summary>
        [Category("浏览器"), Description("浏览器创建新窗口前事件")]
        public event NewWindowEventHandler OnNewWindow;

        /// <summary>
        /// 标题更改事件
        /// </summary>
        [Category("浏览器"), Description("标题更改事件")]
        public event TitleChangedEventHandler OnTitleChanged;

        /// <summary>
        /// 地址更改事件
        /// </summary>
        [Category("浏览器"), Description("地址更改事件")]
        public event AddressChangedEventHandler OnAddressChanged;

        /// <summary>
        /// 目标Url更改事件
        /// </summary>
        [Category("浏览器"), Description("目标Url更改事件")]
        public event TargetUrlChangedEventHandler OnTargetUrlChanged;

        /// <summary>
        /// 加载开始事件
        /// </summary>
        [Category("浏览器"), Description("加载开始事件")]
        public event LoadEventHandler OnLoadStart;

        /// <summary>
        /// 加载结束事件
        /// </summary>
        [Category("浏览器"), Description("加载结束事件")]
        public event LoadEventHandler OnLoadEnd;

        /// <summary>
        /// 加载状态更改事件
        /// </summary>
        [Category("浏览器"), Description("加载状态更改事件")]
        public event LoadingStateChangeEventHandler OnLoadingStateChange;

        #endregion

        #region 事件调用

        /// <summary>
        /// 创建新窗口前
        /// </summary>
        internal void NewWindow(string targetUrl, CancelEventArgs e)
        {
            if (OnNewWindow != null)
            {
                OnNewWindow(targetUrl, e);
            }
        }

        /// <summary>
        /// 浏览器创建
        /// </summary>
        internal void OnCreated(CefBrowser browser)
        {
            if (CefBrowser != null)
                return;
            CefBrowser = browser;
            var handle = CefBrowser.GetHost().GetWindowHandle();
            ResizeWindow(handle, Width, Height);
        }

        /// <summary>
        /// 标题更改
        /// </summary>
        internal void TitleChanged(string title)
        {
            if (OnTitleChanged != null)
            {
                OnTitleChanged(title);
            }
        }

        /// <summary>
        /// 地址更改
        /// </summary>
        internal void AddressChanged(string url)
        {
            if (OnAddressChanged != null)
            {
                OnAddressChanged(url);
            }
        }

        /// <summary>
        /// 目标Url更改
        /// </summary>
        internal void TargetUrlChanged(string value)
        {
            if (OnTargetUrlChanged != null)
            {
                OnTargetUrlChanged(value);
            }
        }

        /// <summary>
        /// 加载开始
        /// </summary>
        internal void LoadStart(CefBrowser browser, CefFrame frame)
        {
            if (OnLoadStart != null)
            {
                OnLoadStart(browser, frame);
            }
        }

        /// <summary>
        /// 加载结束
        /// </summary>
        internal void LoadEnd(CefBrowser browser, CefFrame frame)
        {
            if (OnLoadEnd != null)
            {
                OnLoadEnd(browser, frame);
            }
            GetCookie();
            GetDocumentText();
        }

        /// <summary>
        /// 加载结束
        /// </summary>
        internal void LoadingStateChange(bool isLoading, bool canGoBack, bool canGoForward)
        {
            if (OnLoadingStateChange != null)
            {
                OnLoadingStateChange(isLoading, canGoBack, canGoForward);
            }
        }

        #endregion

        #region 事件处理

        /// <summary>
        /// 控件加载事件
        /// </summary>
        private void CefBrowserEx_Load(object sender, EventArgs e)
        {
            if (IsDesignMode())
                return;
            CreateBrowser();
        }

        /// <summary>
        /// 重设大小事件
        /// </summary>
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            var form = TopLevelControl as Form;
            if (form != null && form.WindowState != FormWindowState.Minimized && CefBrowser != null)
            {
                var handle = CefBrowser.GetHost().GetWindowHandle();
                ResizeWindow(handle, Width, Height);
            }
        }

        /// <summary>
        /// 应用程序退出事件
        /// </summary>
        private void Application_ThreadExit(object sender, EventArgs e)
        {
            CefRuntime.Shutdown();
        }

        #endregion

        #region 私有方法

        /// <summary>
        /// 当前是否为设计模式
        /// </summary>
        private bool IsDesignMode()
        {
            return (DesignMode || Process.GetCurrentProcess().ProcessName == "devenv");
        }

        /// <summary>
        /// 创建浏览器
        /// </summary>
        private void CreateBrowser()
        {
            var windowInfo = CefWindowInfo.Create();
            windowInfo.SetAsChild(Handle, new CefRectangle(0, 0, Width, Height));
            var client = new WebClient(this);
            var settings = new CefBrowserSettings();
            CefBrowserHost.CreateBrowser(windowInfo, client, settings, Url ?? "about:blank");
        }

        /// <summary>
        /// 重设窗口大小
        /// </summary>
        /// <param name="handle">窗口句柄</param>
        /// <param name="width">宽度</param>
        /// <param name="height">高度</param>
        private void ResizeWindow(IntPtr handle, int width, int height)
        {
            if (handle != IntPtr.Zero)
            {
                NativeMethod.SetWindowPos(handle, IntPtr.Zero, 0, 0, width, height, 0x0002 | 0x0004);
            }
        }

        /// <summary>
        /// 获取Cookie
        /// </summary>
        private void GetCookie()
        {
            cefCookies = new CefCookies();
            if (JustGetCurrentCookie)
            {
                string currentUrl = CefBrowser.GetMainFrame().Url;
                CefCookieManager.Global.VisitUrlCookies(currentUrl, true, cefCookies);
            }
            else
            {
                CefCookieManager.Global.VisitAllCookies(cefCookies);
            }
        }

        /// <summary>
        /// 获取页面HTML内容
        /// </summary>
        private void GetDocumentText()
        {
            documentText = new CefString();
            CefBrowser.GetMainFrame().GetSource(documentText);
        }

        #endregion

        #region 公有方法

        /// <summary>
        /// 跳转到地址
        /// </summary>
        public void Navigate(string url)
        {
            CefBrowser.GetMainFrame().LoadUrl(url);
        }

        /// <summary>
        /// 停止
        /// </summary>
        public void Stop()
        {
            CefBrowser.StopLoad();
        }

        /// <summary>
        /// 前进
        /// </summary>
        public void GoForward()
        {
            CefBrowser.GoForward();
        }

        /// <summary>
        /// 后退
        /// </summary>
        public void GoBack()
        {
            CefBrowser.GoBack();
        }

        /// <summary>
        /// 刷新
        /// </summary>
        public void Reload()
        {
            CefBrowser.Reload();
        }

        /// <summary>
        /// 执行JS脚本
        /// </summary>
        /// <param name="js">"CreatePage(1,2,3);"</param>
        public void RunScript(string js)
        {
            var frame = CefBrowser.GetMainFrame();
            frame.ExecuteJavaScript(js, frame.Url, 0);
        }

        /// <summary>
        /// 设置Cookie
        /// </summary>
        public void SetCookie(string url, CefCookie cookie)
        {
            CefCookieManager.Global.SetCookie(url, cookie);
        }

        #endregion
    }
}