/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Core
{
	public class WebViewManager : MonoBehaviour
	{
		// Fields
		private static WebViewManager instance;
		[CompilerGenerated]
		private Action<string> _Callback_k__BackingField;
		private Action<string> onError;
		private Action<string> onLoaded;
		private bool iOSCustomFontInitialized;
		private WebViewObject _webViewObject;
		private static bool _isCustomFontEnable;
		private int currentCustomFontFileIndex;
		private string[] fontFileArray;
		private string currentCustomFontContentCache;
		[CompilerGenerated]
		private bool _Visible_k__BackingField;
		[CompilerGenerated]
		private Action _OnDpiChangedAction_k__BackingField;
		private Vector4 marginNow;
		private float screenDpi;
		private bool screenDpiChangedWhileInvisible;
	
		// Properties
		public static WebViewManager Instance { get; }
		public Action<string> Callback { [CompilerGenerated] get; [CompilerGenerated] set; }
		public static bool HasInstance { get; }
		public Action<string> OnError { set; }
		public Action<string> OnLoaded { set; }
		private WebViewObject webViewObject { get; }
		public static bool IsCustomFontEnable { get; set; }
		public int CurrentCustomFontFileIndex { set; }
		public bool Visible { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Action OnDpiChangedAction { [CompilerGenerated] private get; [CompilerGenerated] set; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<string> __9__42_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _Awake_b__42_0(string msg);
		}
	
		[CompilerGenerated]
		private sealed class _SetMarginBackCoroutine_d__47 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public WebViewManager __4__this;
			public Vector4 oldMargin;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetMarginBackCoroutine_d__47(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public WebViewManager();
		static WebViewManager();
	
		// Methods
		private void UpdateScreenDpi();
		private void ReloadCurrentCustomFontContent();
		private bool IsScreenDpiChanged();
		private void Awake();
		private void OnLoadedCallback(string msg);
		private void OnErrorCallback(string error);
		private void OnApplicationFocus(bool focus);
		private void OnDpiChange();
		[IteratorStateMachine]
		private IEnumerator SetMarginBackCoroutine(Vector4 oldMargin);
		public void ClearFontFilePaths();
		private void OnDestroy();
		public void InitCustomFontFileInfo(string[] fontFileNames, int currentCustomFontFileIndex);
		private void InitIOSCustomFont();
		private void DisableIOSCustomFont();
		public void OpenWeb(string url);
		public void LoadWeb(string url);
		public void ClearHistory();
		public void SetMargins(int leftMargin, int topMargin, int rightMargin, int bottomMargin);
		public void UnloadWebView();
		public void DestroyWebViewObject();
		public void EvaluateJS(string js);
		public void SetVisible(bool visible);
		public void ClearCaches();
		public void Reload();
		public bool CanGoBack();
		public void GoBack();
		[CompilerGenerated]
		private void _get_webViewObject_b__18_0(string msg);
	}
}
