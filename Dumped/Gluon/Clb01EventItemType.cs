using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum Clb01EventItemType
	{
		NONE = 0,
		EXCHANGE_ITEM_01 = 10101,
		EXCHANGE_ITEM_02 = 10102,
		CLB_01_EVENT_POINT_01 = 10201
	}
}
