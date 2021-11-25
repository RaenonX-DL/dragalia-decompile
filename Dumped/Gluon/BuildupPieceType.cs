using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum BuildupPieceType
	{
		NONE,
		LIMIT_BREAK,
		LIMIT_OVER,
		CREST_SLOT_TYPE_1,
		CREST_SLOT_TYPE_2,
		WEAPON_PASSIVE_CHARA,
		ADD_EQUIP_COUNT,
		BUILDUP_LEVEL,
		WEAPOM_PASSIVE_ABILITY,
		CREST_SLOT_TYPE_3
	}
}
