using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class EventE02660 : EventBase<EventE02660>
	{
		[Required]
		[Key(1)]
		public CharacterId[] boundChrs;

		[Key(2)]
		public CharacterId ownerId;

		[Key(3)]
		public int actionId;

		[Key(4)]
		public short actionPartsIndex;
	}
}
