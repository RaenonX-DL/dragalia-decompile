using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public struct RegenerationSyncData
	{
		[Key(0)]
		public int multiPlayKey;

		[ActionConditionId]
		[Key(1)]
		public int conditionId;

		[Key(2)]
		public float healValue1;

		[Key(3)]
		public float healValue2;

		[Key(4)]
		public float healValue3;

		[Key(5)]
		public float durationSec;

		[Key(6)]
		public int abilityId;

		[Key(7)]
		public CharacterId from;

		[Key(8)]
		public int productId;

		[Key(9)]
		public byte hitTargetGroup;

		[Key(10)]
		public int skillId;

		[Key(11)]
		public float healValue4;

		[Key(12)]
		public int slipDamageGroup;

		[Key(13)]
		public float rateIncreaseByTime;

		[Key(14)]
		public float increaseRate;
	}
}
