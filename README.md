# CefBrowserEx

CEF简介：
嵌入式Chromium框架(简称CEF) 是一个由Marshall Greenblatt在2008建立的开源项目，它主要目的是开发一个基于Google Chromium的Webbrowser控件。CEF支持一系列的编程语言和操作系统，并且能很容易地整合到新的或已有的工程中去。


本git上有个CefSharp的项目，是一个由CEF延伸的C#控件项目，不过它用起来很不方便，需要了解很多东西，使用方式也是用继承重写的，与C#使用控件的方式完全不一样。

这个版本就是从CefSharp再次延伸而出的，完全符合C#开发习惯的一个CEF浏览器控件。直接把控件添加到VS的工具栏，有需要就直接像内置控件一样拖到界面上就可以了，里面的功能函数也和内置的WebBrowser一样，使用起来基本不用再去了解什么东西。
