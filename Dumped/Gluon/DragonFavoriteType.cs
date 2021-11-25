using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum DragonFavoriteType
	{
		NONE = 0,
		FOOD = 1,
		TOY = 2,
		ACCESSORY = 3,
		BOOK = 4,
		MAGIC_ITEM = 5,
		ALL = 99
	}
}
