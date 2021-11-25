using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class ThrowRelease : EventBase<ThrowRelease>
	{
		[Key(1)]
		public CharacterId thrower;

		[Key(2)]
		public CharacterId target;

		[Key(3)]
		public bool isThrow;

		[Key(4)]
		public int sequenceId;
	}
}
