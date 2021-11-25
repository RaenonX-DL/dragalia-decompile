using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum AlbumPassiveType
	{
		CHARA_TAKE = 101,
		CHARA_LEVEL = 102,
		CHARA_MANA_CIRCLE = 103,
		DRAGON_TAKE = 201,
		DRAGON_LIMIT_BREAK = 202,
		DRAGON_RELIABILITY_LEVEL = 203
	}
}
