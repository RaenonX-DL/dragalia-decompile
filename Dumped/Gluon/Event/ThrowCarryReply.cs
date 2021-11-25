using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class ThrowCarryReply : EventBase<ThrowCarryReply>
	{
		[Key(1)]
		public CharacterId thrower;

		[Key(2)]
		public CharacterId target;

		[Key(3)]
		public bool isAccepted;

		[Key(4)]
		public int sequenceId;
	}
}
