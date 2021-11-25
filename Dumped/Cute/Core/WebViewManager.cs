using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Cute.Core
{
	public class WebViewManager : MonoBehaviour
	{
		private static WebViewManager instance;

		private Action<string> onError;

		private Action<string> onLoaded;

		private bool iOSCustomFontInitialized;

		private WebViewObject _webViewObject;

		private static bool _isCustomFontEnable;

		private int currentCustomFontFileIndex;

		private string[] fontFileArray;

		private string currentCustomFontContentCache;

		private Vector4 marginNow;

		private float screenDpi;

		private bool screenDpiChangedWhileInvisible;

		public static WebViewManager Instance => null;

		public Action<string> Callback
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static bool HasInstance => default(bool);

		public Action<string> OnError
		{
			set
			{
			}
		}

		public Action<string> OnLoaded
		{
			set
			{
			}
		}

		private WebViewObject webViewObject => null;

		public static bool IsCustomFontEnable
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public int CurrentCustomFontFileIndex
		{
			set
			{
			}
		}

		public bool Visible
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Action OnDpiChangedAction
		{
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private void UpdateScreenDpi()
		{
		}

		private void ReloadCurrentCustomFontContent()
		{
		}

		private bool IsScreenDpiChanged()
		{
			return default(bool);
		}

		private void Awake()
		{
		}

		private void OnLoadedCallback(string msg)
		{
		}

		private void OnErrorCallback(string error)
		{
		}

		private void OnApplicationFocus(bool focus)
		{
		}

		private void OnDpiChange()
		{
		}

		private IEnumerator SetMarginBackCoroutine(Vector4 oldMargin)
		{
			return null;
		}

		public void ClearFontFilePaths()
		{
		}

		private void OnDestroy()
		{
		}

		public void InitCustomFontFileInfo(string[] fontFileNames, int currentCustomFontFileIndex)
		{
		}

		private void InitIOSCustomFont()
		{
		}

		private void DisableIOSCustomFont()
		{
		}

		public void OpenWeb(string url)
		{
		}

		public void LoadWeb(string url)
		{
		}

		public void ClearHistory()
		{
		}

		public void SetMargins(int leftMargin, int topMargin, int rightMargin, int bottomMargin)
		{
		}

		public void UnloadWebView()
		{
		}

		public void DestroyWebViewObject()
		{
		}

		public void EvaluateJS(string js)
		{
		}

		public void SetVisible(bool visible)
		{
		}

		public void ClearCaches()
		{
		}

		public void Reload()
		{
		}

		public bool CanGoBack()
		{
			return default(bool);
		}

		public void GoBack()
		{
		}
	}
}
