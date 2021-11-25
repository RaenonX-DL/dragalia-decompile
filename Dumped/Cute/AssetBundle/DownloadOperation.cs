using System;
using System.Collections.Generic;

namespace Cute.AssetBundle
{
	public class DownloadOperation : AssetDownloader.Operation
	{
		public DownloadOperation(IEnumerable<string> assets, Action onSuccess, Action<DownloadErrorType, string> onFailed, bool autoStart)
		{
		}
	}
}
