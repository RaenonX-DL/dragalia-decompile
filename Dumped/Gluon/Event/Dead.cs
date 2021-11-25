using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class Dead : EventBase<Dead>
	{
		[Required]
		[Key(1)]
		public CharacterId character;

		[Key(2)]
		public short popCount;
	}
}
