using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class ResetBuffRequest : EventBase<ResetBuffRequest>
	{
		[Required]
		[Key(1)]
		public CharacterId character;

		[Key(2)]
		public int conditionId;

		[Key(3)]
		public int abilityId;

		[Key(4)]
		public int productId;
	}
}
