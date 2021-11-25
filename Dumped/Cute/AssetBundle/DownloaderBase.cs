using System.Collections.Generic;

namespace Cute.AssetBundle
{
	public abstract class DownloaderBase
	{
		public delegate void ResponseCB(string protocol);

		public delegate void FailureCB(DownloadErrorType errorType, string errorMessage);

		public const string HTTP_1_0 = "http/1.0";

		public const string HTTP_1_1 = "http/1.1";

		public const string SPDY_3 = "spdy/3.1";

		public const string HTTP_2 = "h2";

		public const string H2_PRIOR_KNOWLEDGE = "h2_prior_knowledge";

		public const string QUIC = "quic";

		private static Dictionary<string, ResponseCB> responseCallbackDict;

		private static Dictionary<string, FailureCB> failureCallbackDict;

		protected static void OnResponseCallback(string url, string protocol)
		{
		}

		private static void DoResponseCallback(string url, string protocol)
		{
		}

		protected static void OnFailureCallback(string url, DownloadErrorType errorType, string errorMsg)
		{
		}

		private static void DoFailureCallback(string url, DownloadErrorType errorType, string errorMsg)
		{
		}

		public void Download(string url, string filePath, Dictionary<string, string> headers, bool checkHash, int retry, ResponseCB responseCB, FailureCB failureCB)
		{
		}

		protected abstract void DoDownload(string url, string fileName, Dictionary<string, string> headers, bool checkHash, int retry);

		public virtual void Cancel()
		{
		}

		public virtual void Dispose()
		{
		}
	}
}
