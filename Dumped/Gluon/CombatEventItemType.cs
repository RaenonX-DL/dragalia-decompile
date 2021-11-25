using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum CombatEventItemType
	{
		NONE = 0,
		EXCHANGE_ITEM_01 = 10101,
		EVENT_POINT = 10201,
		ADVENT_ITEM_01 = 10301,
		QUEST_UNLOCK_ITEM_01 = 10401,
		STORY_UNLOCK_ITEM_01 = 10501
	}
}
