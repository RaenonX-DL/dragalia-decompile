using System.Runtime.CompilerServices;
using Gluon.Event;
using UnityEngine;

namespace Gluon
{
	public class CharacterDamageIntermediate
	{
		public int damage;

		public bool isBarrierBroken;

		public bool isLethal;

		public bool isKiller;

		public bool isTolerance;

		public bool isPenetrateShield;

		public float pureElementalRate;

		public float dragonTimerDamage;

		public CharacterBase damageOwner;

		public int overdriveDamage;

		public bool isOnCollided;

		public float hpDrainRate => default(float);

		public float hpDrainRate2 => default(float);

		public int additionRecoveryDp => default(int);

		public float recoveryDragonTime => default(float);

		public ActionHitExecType hitExecType => default(ActionHitExecType);

		public bool isQuestSkill => default(bool);

		public bool enableApplyMultipleDebuff => default(bool);

		public AttackHit attackHit
		{
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public CollisionHitAttribute hitAttr
		{
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int skillId => default(int);

		public int actionId => default(int);

		public Vector3 hitPos => default(Vector3);

		public bool isDamageMyself => default(bool);

		public bool isSubstitudeDamage => default(bool);

		public bool isCancelBind => default(bool);

		public float skillDamageUpBuffRate => default(float);

		public float burstDamageUpBuffRate => default(float);

		public bool isTensionMax => default(bool);

		public bool isInspirationMax => default(bool);

		public bool isAttrDragon => default(bool);

		public bool isAnnihilationAttack => default(bool);

		public void Clear()
		{
		}

		public bool HasMultiPlayOwner(CharacterBase character)
		{
			return default(bool);
		}

		public void WriteToAttackHit(AttackHit outAttackHit)
		{
		}

		public void ReadFromAttackHit(AttackHit inAttackHit, CollisionHitAttribute inHitAttr)
		{
		}
	}
}
