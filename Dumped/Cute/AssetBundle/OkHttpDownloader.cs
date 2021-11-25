using System.Collections.Generic;

namespace Cute.AssetBundle
{
	public class OkHttpDownloader : DownloaderBase
	{
		private OkHttpPlugin okHttpPlugin;

		private readonly OkHttpPluginCallback callback;

		public OkHttpDownloader(int timeout = 10)
		{
		}

		public void SetMaxRequestsPerHost(int maxRequests)
		{
		}

		public void SetMaxRequests(int maxRequests)
		{
		}

		protected override void DoDownload(string url, string fileName, Dictionary<string, string> headers, bool checkHash, int retry)
		{
		}

		public override void Cancel()
		{
		}

		public override void Dispose()
		{
		}
	}
}
