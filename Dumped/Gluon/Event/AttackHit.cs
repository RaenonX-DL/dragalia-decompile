using MessagePack;
using UnityEngine;

namespace Gluon.Event
{
	[MessagePackObject(false)]
	public class AttackHit : EventBase<AttackHit>
	{
		[Key(1)]
		public CharacterId from;

		[Key(2)]
		public int damage;

		[Key(3)]
		public int breakDamage;

		[Required]
		[Key(4)]
		public CharacterId to;

		[Key(5)]
		public Vector3 hitPos;

		[Key(6)]
		public int bulletId;

		[Key(7)]
		public float elementRate;

		[Key(8)]
		public int applyAbnormalStatusResult;

		[Key(9)]
		public bool isCritical;

		[Key(10)]
		public float rotation;

		[Key(11)]
		public int reaction;

		[Key(12)]
		public KnockBack knockBack;

		[Key(13)]
		public Absorption absorption;

		[Key(14)]
		public BlastUp blastUp;

		[Key(15)]
		public BlastDown blastDown;

		[Key(16)]
		public BlastSp blastSp;

		[ActionId]
		[Key(17)]
		public int actionId;

		[SkillIdOrZero]
		[Key(18)]
		public int skillId;

		[Key(19)]
		public int hitProduction;

		[Key(20)]
		public CharacterId additionalAttackFrom;

		[Key(21)]
		public byte flags;

		[Key(22)]
		public int moveEventTimestamp;

		[Key(23)]
		public float dragonTimerDamage;

		[Key(24)]
		public float skillDamageUpBuffRate;

		[Key(25)]
		public byte characterType;

		[Key(26)]
		public short elementIndex;

		[Key(27)]
		public int productId;

		[Key(28)]
		public float burstDamageUpBuffRate;

		[Key(29)]
		public long designatedHitEffectResourceId;

		[Key(30)]
		public uint hitAttrLabelCrc32;

		[Key(31)]
		public int buffCount;

		[Key(32)]
		public byte flags2;

		[Key(33)]
		public short popCount;

		public void Clear()
		{
		}
	}
}
