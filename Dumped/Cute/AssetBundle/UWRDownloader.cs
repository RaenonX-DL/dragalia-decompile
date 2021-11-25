using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;

namespace Cute.AssetBundle
{
	public class UWRDownloader : DownloaderBase
	{
		private int timeout;

		private float time;

		private ICoroutineHandler coroutineHandler;

		private List<UnityWebRequest> requestList;

		private List<UWRDownloadHandler> downloadHandlerList;

		public UWRDownloader(ICoroutineHandler coroutineHandler, int timeout = 0)
		{
		}

		protected override void DoDownload(string url, string fileName, Dictionary<string, string> headers, bool checkHash, int retry)
		{
		}

		public override void Cancel()
		{
		}

		protected void DoDownload(string url, string fileName, Dictionary<string, string> headers, bool checkHash, int retry, int retryCount)
		{
		}

		private IEnumerator StartDownload(string url, string fileName, Dictionary<string, string> headers, bool checkHash, int retry, int retryCount)
		{
			return null;
		}

		private bool IsDiskFullError(string errorMessage)
		{
			return default(bool);
		}
	}
}
