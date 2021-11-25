using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class RoomBroken : EventBase<RoomBroken>
	{
		[Key(1)]
		public RoomBrokenType reason;
	}
}
