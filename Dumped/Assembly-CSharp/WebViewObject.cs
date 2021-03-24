/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

[ProjectPrefsAttr]
[ProjectPrefsAttr]
[ProjectPrefsAttr]
[ProjectPrefsAttr]
[ProjectPrefsAttr]
[ProjectPrefsAttr]
[ProjectPrefsAttr]
[ProjectPrefsAttr]
[ProjectPrefsAttr]
[ProjectPrefsAttr]
public class WebViewObject : MonoBehaviour
{
	// Fields
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

	// Properties
	public bool IsKeyboardVisible { get; }

	// Constructors
	public WebViewObject();

	// Methods
	private void OnApplicationPause(bool paused);
	private void Update();
	public void SetKeyboardVisible(string pIsVisible);
	public int AdjustBottomMargin(int bottom);
	public static bool IsWebViewAvailable();
	public void Init(Action<string> cb = null, bool transparent = false, string ua = "", Action<string> err = null, Action<string> httpErr = null, Action<string> ld = null, Action<string> started = null);
	protected virtual void OnDestroy();
	public void SetCenterPositionWithScale(Vector2 center, Vector2 scale);
	public void SetMargins(int left, int top, int right, int bottom, bool relative = false);
	public void SetVisibility(bool v);
	public bool GetVisibility();
	public void LoadURL(string url);
	public void LoadHTML(string html, string baseUrl);
	public void EvaluateJS(string js);
	public int Progress();
	public bool CanGoBack();
	public bool CanGoForward();
	public void GoBack();
	public void GoForward();
	public void CallOnError(string error);
	public void CallOnHttpError(string error);
	public void CallOnStarted(string url);
	public void CallOnLoaded(string url);
	public void CallFromJS(string message);
	public void AddCustomHeader(string headerKey, string headerValue);
	public string GetCustomHeaderValue(string headerKey);
	public void RemoveCustomHeader(string headerKey);
	public void ClearCustomHeader();
	public void ClearCookies();
	public string GetCookies(string url);
	public void ClearCaches();
	public void Reload();
	public void AddFontFilePath(string path1, string path2);
	public void ClearFontFilePaths();
	public void ClearHistory();
	public void InitIOSCustomFont(string js);
	public void DisableIOSCustomFont();
}

