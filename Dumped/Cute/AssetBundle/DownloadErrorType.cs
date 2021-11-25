using System.Runtime.InteropServices;

namespace Cute.AssetBundle
{
	[StructLayout(3, Size = 4)]
	public enum DownloadErrorType
	{
		None,
		HttpError,
		TimeoutError,
		NetworkError,
		SystemError,
		DiskFullError,
		HashCheckError
	}
}
