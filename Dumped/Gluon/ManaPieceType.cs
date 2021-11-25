using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum ManaPieceType
	{
		NONE = 0,
		HP = 10101,
		ATK = 10102,
		HP_ATK = 10103,
		BURSTATTACK = 10201,
		ABILITY_1 = 10301,
		ABILITY_2 = 10302,
		ABILITY_3 = 10303,
		SKILL_1 = 10401,
		SKILL_2 = 10402,
		EXABILITY = 10501,
		ITEM_1 = 10601,
		ITEM_2 = 10602,
		COMBO_1 = 10701,
		MAX_LEVEL_5 = 10801
	}
}
