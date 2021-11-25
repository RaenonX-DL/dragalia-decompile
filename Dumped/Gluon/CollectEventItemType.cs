using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum CollectEventItemType
	{
		NONE = 0,
		COLLECT_EVENT_POINT_1 = 10001,
		COLLECT_EVENT_POINT_2 = 10002,
		COLLECT_EVENT_POINT_3 = 10003
	}
}
