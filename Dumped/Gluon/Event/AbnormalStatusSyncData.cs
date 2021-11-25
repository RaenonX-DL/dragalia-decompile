using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public struct AbnormalStatusSyncData
	{
		[ActionConditionId]
		[Key(0)]
		public int elemId;

		[Key(1)]
		public ushort durationNum;

		[Key(2)]
		public float durationTime;

		[Key(3)]
		public float baseSlipDamage;

		[Key(4)]
		public float lifeSec;

		[Key(5)]
		public CharacterId from;
	}
}
