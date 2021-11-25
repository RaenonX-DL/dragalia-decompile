using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class CharacterCustomPointEvent : EventBase<CharacterCustomPointEvent>
	{
		[Required]
		[Key(1)]
		public int type;

		[Required]
		[Key(2)]
		public CharacterId target;

		[Required]
		[Key(3)]
		public int index;

		[Required]
		[Key(4)]
		public int value;
	}
}
