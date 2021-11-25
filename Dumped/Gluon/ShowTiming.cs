using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum ShowTiming
	{
		NONE,
		ENTRY,
		ACTION_PARTS
	}
}
