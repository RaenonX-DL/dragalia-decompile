using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class CharacterSpecialState : EventBase<CharacterSpecialState>
	{
		[Key(1)]
		public byte type;

		[Required]
		[Key(2)]
		public CharacterId target;

		[Key(3)]
		public int value;

		[Key(4)]
		public float floatValue;

		[Key(5)]
		public int[] values;
	}
}
