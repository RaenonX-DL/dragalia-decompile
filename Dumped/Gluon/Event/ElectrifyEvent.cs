using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class ElectrifyEvent : EventBase<ElectrifyEvent>
	{
		[Key(1)]
		public CharacterId character;

		[Key(2)]
		public int stackCount;

		[Key(3)]
		public int state;
	}
}
