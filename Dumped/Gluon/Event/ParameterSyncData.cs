using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public struct ParameterSyncData
	{
		[Key(0)]
		public int multiPlayKey;

		[Key(1)]
		public byte type;

		[ActionConditionId]
		[Key(2)]
		public int conditionId;

		[Key(3)]
		public float durationSec;

		[Key(4)]
		public short durationNum;

		[Key(5)]
		public int skillId;

		[Key(6)]
		public int actionId;

		[Key(7)]
		public int abilityId;

		[Key(8)]
		public int productId;

		[Key(9)]
		public float rate;

		[Key(10)]
		public byte hitTargetGroup;

		[Key(11)]
		public CharacterId from;

		[Key(12)]
		public float sacrificeShieldConsumeHp;
	}
}
