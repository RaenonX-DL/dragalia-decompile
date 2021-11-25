using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class Dispel : EventBase<Dispel>
	{
		[Required]
		[Key(1)]
		public CharacterId target;

		[Key(2)]
		public int actionId;

		[Required]
		[Key(3)]
		public CharacterId from;
	}
}
