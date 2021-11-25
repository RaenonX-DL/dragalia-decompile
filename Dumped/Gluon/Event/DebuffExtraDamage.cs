using MessagePack;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class DebuffExtraDamage : EventBase<DebuffExtraDamage>
	{
		[Required]
		[Key(1)]
		public CharacterId target;

		[ActionConditionId]
		[Key(2)]
		public int actionConditionId;

		[Key(3)]
		public int damage;

		[Key(4)]
		public CharacterId from;

		[Key(5)]
		public float extraElementRate;

		[Key(6)]
		public uint hitAttrCrc32;

		[Key(7)]
		public int actionId;

		[Key(8)]
		public bool isHostSync;

		[Key(9)]
		public int buffExplosionHitId;

		[Key(10)]
		public bool isPropagation;
	}
}
