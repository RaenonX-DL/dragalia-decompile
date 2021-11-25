using System;
using System.Runtime.InteropServices;
using Cute.Http;

namespace Gluon
{
	public class WebViewUtility
	{
		private enum PratformCategory
		{
			None = -1,
			IOS,
			Android
		}

		private const string urlParameterForlangAndRegionFormat = "?pf={0}&lang={1}&region={2}";

		public static void FetchWebViewUrlList(Action onCompleted, [Optional] Action<ErrorType, int> onError, bool forceUpdate = false)
		{
		}

		public static string GetWebViewUrl(string functionName, WebViewPopup.WebViewCategory category = WebViewPopup.WebViewCategory.Help)
		{
			return null;
		}

		public static string CheckPreloadUrl(string url)
		{
			return null;
		}

		public static string GetUrlParameterForPlatformAndLanguageAndRegion(WebViewPopup.WebViewCategory category = WebViewPopup.WebViewCategory.Help)
		{
			return null;
		}
	}
}
