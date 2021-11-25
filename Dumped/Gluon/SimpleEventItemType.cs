using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum SimpleEventItemType
	{
		NONE = 0,
		EXCHANGE_ITEM_01 = 10101,
		EXCHANGE_ITEM_02 = 10102,
		EXCHANGE_ITEM_03 = 10103
	}
}
