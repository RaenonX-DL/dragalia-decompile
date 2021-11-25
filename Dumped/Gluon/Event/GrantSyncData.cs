using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public struct GrantSyncData
	{
		[Key(0)]
		public int multiPlayKey;

		[Key(1)]
		public byte trigger;

		[ActionConditionId]
		[Key(2)]
		public int conditionId;

		[Key(3)]
		public float durationSec;

		[Key(4)]
		public int attribute;

		[Key(5)]
		public int abilityId;
	}
}
