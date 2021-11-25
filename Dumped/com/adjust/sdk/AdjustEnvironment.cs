using System.Runtime.InteropServices;

namespace com.adjust.sdk
{
	[StructLayout(3, Size = 4)]
	public enum AdjustEnvironment
	{
		Sandbox,
		Production
	}
}
