using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class BRGetItemEvent : EventBase<BRGetItemEvent>
	{
		[Key(1)]
		public BRItemId target;

		[Key(2)]
		public CharacterId getter;
	}
}
