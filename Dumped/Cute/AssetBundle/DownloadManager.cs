using System.Collections.Generic;
using UnityEngine;

namespace Cute.AssetBundle
{
	public class DownloadManager : MonoBehaviour
	{
		private DownloaderBase downloader;

		private static DownloadManager instance;

		private static int timeout;

		public static int TimeOut
		{
			set
			{
			}
		}

		public static DownloadManager Instance => null;

		private DownloaderBase Downloader => null;

		public void Download(string url, string filePath, Dictionary<string, string> headers, bool checkHash, int retry, DownloaderBase.ResponseCB responseCB, DownloaderBase.FailureCB failureCB)
		{
		}

		public void SetMaxRequestsPerHost(int maxRequests)
		{
		}

		public void SetMaxRequests(int maxRequests)
		{
		}

		public void Cancel()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
