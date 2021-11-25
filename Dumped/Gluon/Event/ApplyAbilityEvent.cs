using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class ApplyAbilityEvent : EventBase<ApplyAbilityEvent>
	{
		[Required]
		[Key(1)]
		public CharacterId owner;

		[Key(2)]
		public int abilityId;

		[Key(3)]
		public int idx;

		[Key(4)]
		public int count;
	}
}
