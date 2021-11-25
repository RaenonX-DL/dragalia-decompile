using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum ExRushEventItemType
	{
		NONE = 0,
		EX_RUSH_POINT_01 = 10101,
		EX_RUSH_POINT_02 = 10102
	}
}
