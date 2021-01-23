/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using Gluon.Http;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class WebViewUtility
	{
		// Fields
		private const string urlParameterForlangAndRegionFormat = "?pf={0}&lang={1}&region={2}";
	
		// Nested types
		private enum PratformCategory
		{
			None = -1,
			IOS = 0,
			Android = 1
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass2_0
		{
			// Fields
			public Action onCompleted;
	
			// Constructors
			public __c__DisplayClass2_0();
	
			// Methods
			internal void _FetchWebViewUrlList_b__0(WebviewVersionUrlListResponse res);
		}
	
		// Constructors
		public WebViewUtility();
	
		// Methods
		public static void FetchWebViewUrlList(Action onCompleted, Action<ErrorType, int> onError = null, bool forceUpdate = false);
		public static string GetWebViewUrl(string functionName, WebViewPopup.WebViewCategory category = WebViewPopup.WebViewCategory.Help);
		public static string CheckPreloadUrl(string url);
		public static string GetUrlParameterForPlatformAndLanguageAndRegion(WebViewPopup.WebViewCategory category = WebViewPopup.WebViewCategory.Help);
	}
}
