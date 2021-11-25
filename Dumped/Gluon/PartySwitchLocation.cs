using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum PartySwitchLocation
	{
		QuestSelect,
		MatchingRoomHost,
		MatchingRoomGuest,
		QuestPrepare,
		MultiCreate,
		MultiCreateCustom,
		MultiCreatePrivate,
		MultiCreateLocation,
		MultiCreateGuild,
		MultiJoinAuto,
		MultiJoinPrivate,
		MultiJoinRoomList,
		MultiJoinGuild,
		MultiChangeParty,
		MultiQuestPrepare,
		QuestStart
	}
}
