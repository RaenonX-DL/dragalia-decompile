using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class ChangeBuffDuration : EventBase<ChangeBuffDuration>
	{
		[Required]
		[Key(1)]
		public CharacterId character;

		[Required]
		[Key(2)]
		public int category;

		[Required]
		[Key(3)]
		public CharacterBuffType type;

		[Required]
		[Key(4)]
		public int multiPlayKey;

		[Required]
		[Key(5)]
		public float durationSec;
	}
}
