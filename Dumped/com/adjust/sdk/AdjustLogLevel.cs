using System.Runtime.InteropServices;

namespace com.adjust.sdk
{
	[StructLayout(3, Size = 4)]
	public enum AdjustLogLevel
	{
		Verbose = 1,
		Debug,
		Info,
		Warn,
		Error,
		Assert,
		Suppress
	}
}
