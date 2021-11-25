using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cute.AssetBundle
{
	public class OkHttpPlugin : IDisposable
	{
		public enum ErrorType
		{
			Timeout,
			IOException,
			Other
		}

		private AndroidJavaObject okHttpDownloadObject;

		public OkHttpPlugin()
		{
		}

		public OkHttpPlugin(int timeout)
		{
		}

		public void Download(string url, string fileName, Dictionary<string, string> headers, bool checkHash, int retry, OkHttpPluginCallback callback)
		{
		}

		public void SetMaxRequests(int maxRequests)
		{
		}

		public void SetMaxRequestsPerHost(int maxRequests)
		{
		}

		public void Cancel()
		{
		}

		public void Dispose()
		{
		}
	}
}
