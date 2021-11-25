using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public struct UnifiedParameterSyncData
	{
		[Key(0)]
		public int multiPlayKey;

		[ActionConditionId]
		[Key(1)]
		public int conditionId;

		[Key(2)]
		public float durationSec;

		[Key(3)]
		public short durationNum;

		[Key(4)]
		public int skillId;

		[Key(5)]
		public int actionId;

		[Key(6)]
		public int abilityId;

		[Key(7)]
		public int productId;

		[Key(8)]
		public byte hitTargetGroup;

		[Key(9)]
		public CharacterId from;

		[Key(10)]
		public float sacrificeShieldConsumeHp;
	}
}
