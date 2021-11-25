using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class ThrowCarryRequest : EventBase<ThrowCarryRequest>
	{
		[Key(1)]
		public CharacterId thrower;

		[Key(2)]
		public CharacterId target;

		[Key(3)]
		public int sequenceId;
	}
}
