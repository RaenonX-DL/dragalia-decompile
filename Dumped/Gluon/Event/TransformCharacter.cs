using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class TransformCharacter : EventBase<TransformCharacter>
	{
		[Required]
		[Key(1)]
		public CharacterId characterId;

		[Key(2)]
		public bool isHuman;

		[Key(3)]
		public bool isFinishDragon;

		[Key(4)]
		public int dp;
	}
}
