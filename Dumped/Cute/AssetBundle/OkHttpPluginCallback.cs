using System;
using UnityEngine;

namespace Cute.AssetBundle
{
	public class OkHttpPluginCallback : AndroidJavaProxy
	{
		private Action<string, string> onResponseCallback;

		private Action<string, DownloadErrorType, string> onFailureCallback;

		public OkHttpPluginCallback(Action<string, string> onResponseCallback, Action<string, DownloadErrorType, string> onFailureCallback)
		{
		}

		public void onResponse(string url, string protocol)
		{
		}

		public void onFailure(string url, int errorType, string errorMsg)
		{
		}
	}
}
