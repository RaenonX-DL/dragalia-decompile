using System;
using System.Runtime.InteropServices;
using Cute.Core;
using UnityEngine;

[ProjectPrefsAttr("appDomain0", "WebViewã\u0083\u0089ã\u0083¡ã\u0082¤ã\u0083³", "[WebView]")]
[ProjectPrefsAttr("appDomain1", "WebViewã\u0083\u0089ã\u0083¡ã\u0082¤ã\u0083³", "[WebView]")]
[ProjectPrefsAttr("appDomain2", "WebViewã\u0083\u0089ã\u0083¡ã\u0082¤ã\u0083³", "[WebView]")]
[ProjectPrefsAttr("appDomain3", "WebViewã\u0083\u0089ã\u0083¡ã\u0082¤ã\u0083³", "[WebView]")]
[ProjectPrefsAttr("appDomain4", "WebViewã\u0083\u0089ã\u0083¡ã\u0082¤ã\u0083³", "[WebView]")]
[ProjectPrefsAttr("appDomain5", "WebViewã\u0083\u0089ã\u0083¡ã\u0082¤ã\u0083³", "[WebView]")]
[ProjectPrefsAttr("appDomain6", "WebViewã\u0083\u0089ã\u0083¡ã\u0082¤ã\u0083³", "[WebView]")]
[ProjectPrefsAttr("appDomain7", "WebViewã\u0083\u0089ã\u0083¡ã\u0082¤ã\u0083³", "[WebView]")]
[ProjectPrefsAttr("appDomain8", "WebViewã\u0083\u0089ã\u0083¡ã\u0082¤ã\u0083³", "[WebView]")]
[ProjectPrefsAttr("appDomain9", "WebViewã\u0083\u0089ã\u0083¡ã\u0082¤ã\u0083³", "[WebView]")]
public class WebViewObject : MonoBehaviour
{
	private Action<string> onJS;

	private Action<string> onError;

	private Action<string> onHttpError;

	private Action<string> onStarted;

	private Action<string> onLoaded;

	private bool visibility;

	private const string appDomains = "appDomain";

	private const int appDomainsLength = 10;

	private int mMarginLeft;

	private int mMarginTop;

	private int mMarginRight;

	private int mMarginBottom;

	private AndroidJavaObject webView;

	private bool mVisibility;

	private bool mIsKeyboardVisible0;

	private bool mIsKeyboardVisible;

	private float mResumedTimestamp;

	public bool IsKeyboardVisible => default(bool);

	private void OnApplicationPause(bool paused)
	{
	}

	private void Update()
	{
	}

	public void SetKeyboardVisible(string pIsVisible)
	{
	}

	public int AdjustBottomMargin(int bottom)
	{
		return default(int);
	}

	public static bool IsWebViewAvailable()
	{
		return default(bool);
	}

	public void Init([Optional] Action<string> cb, bool transparent = false, string ua = "", [Optional] Action<string> err, [Optional] Action<string> httpErr, [Optional] Action<string> ld, [Optional] Action<string> started)
	{
	}

	protected virtual void OnDestroy()
	{
	}

	public void SetCenterPositionWithScale(Vector2 center, Vector2 scale)
	{
	}

	public void SetMargins(int left, int top, int right, int bottom, bool relative = false)
	{
	}

	public void SetVisibility(bool v)
	{
	}

	public bool GetVisibility()
	{
		return default(bool);
	}

	public void LoadURL(string url)
	{
	}

	public void LoadHTML(string html, string baseUrl)
	{
	}

	public void EvaluateJS(string js)
	{
	}

	public int Progress()
	{
		return default(int);
	}

	public bool CanGoBack()
	{
		return default(bool);
	}

	public bool CanGoForward()
	{
		return default(bool);
	}

	public void GoBack()
	{
	}

	public void GoForward()
	{
	}

	public void CallOnError(string error)
	{
	}

	public void CallOnHttpError(string error)
	{
	}

	public void CallOnStarted(string url)
	{
	}

	public void CallOnLoaded(string url)
	{
	}

	public void CallFromJS(string message)
	{
	}

	public void AddCustomHeader(string headerKey, string headerValue)
	{
	}

	public string GetCustomHeaderValue(string headerKey)
	{
		return null;
	}

	public void RemoveCustomHeader(string headerKey)
	{
	}

	public void ClearCustomHeader()
	{
	}

	public void ClearCookies()
	{
	}

	public string GetCookies(string url)
	{
		return null;
	}

	public void ClearCaches()
	{
	}

	public void Reload()
	{
	}

	public void AddFontFilePath(string path1, string path2)
	{
	}

	public void ClearFontFilePaths()
	{
	}

	public void ClearHistory()
	{
	}

	public void InitIOSCustomFont(string js)
	{
	}

	public void DisableIOSCustomFont()
	{
	}
}
