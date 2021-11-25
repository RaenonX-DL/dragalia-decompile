using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum EarnEventItemType
	{
		NONE = 0,
		EARN_POINT_01 = 10001,
		ADVENT_ITEM_01 = 10101,
		EXCHANGE_ITEM_01 = 10201,
		EXCHANGE_ITEM_02 = 10202
	}
}
