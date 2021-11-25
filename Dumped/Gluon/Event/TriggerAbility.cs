using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class TriggerAbility : EventBase<TriggerAbility>
	{
		[Key(1)]
		public AbilityCondition conditionType;

		[Key(2)]
		public CharacterId owner;

		[Key(3)]
		public CharacterId from;

		[Key(4)]
		public CharacterId target;

		[Key(5)]
		public int actionId;

		[Key(6)]
		public int skillId;
	}
}
