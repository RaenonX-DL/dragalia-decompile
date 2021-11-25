using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum MazeEventItemType
	{
		NONE = 0,
		MAZE_POINT_01 = 10101,
		EXCHANGE_ITEM_01 = 10201,
		EXCHANGE_ITEM_02 = 10202,
		EXCHANGE_ITEM_03 = 10203,
		EXCHANGE_ITEM_04 = 10204
	}
}
