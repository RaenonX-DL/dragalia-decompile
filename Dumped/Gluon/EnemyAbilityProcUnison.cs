using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Master;

namespace Gluon
{
	public class EnemyAbilityProcUnison : EnemyAbilityProcBase
	{
		public class ApplyAbnormal
		{
			public CharacterBase attacker;

			public int actionId;

			public int productId;

			public AbnormalStatusType type;

			public bool valid;

			public void Reset()
			{
			}
		}

		private ApplyAbnormal[] _arrayApplyAbnormal;

		private List<ApplyAbnormal> _listApplyAbnormal;

		public EnemyCharacter primary
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public EnemyCharacter secondary
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isPrimary => default(bool);

		public EnemyAbilityProcUnison(EnemyAbility enemyability_, EnemyAbilityElement data_, EnemyCharacter owner_)
		{
		}

		public override void Play()
		{
		}

		public override void Stop()
		{
		}

		public override void OnEntry()
		{
		}

		public override void OnUpdate()
		{
		}

		public override void OnApplyDamage(CharacterDamageIntermediate damageData, bool alive)
		{
		}

		public override void OnApplySlipDamage(ref EnemyAbility.Argument arg, int damage, AbnormalStatusType abnormalStatusType, CharacterBuffType buffType)
		{
		}

		public override void OnApplyDebuffExtraDamage(ref EnemyAbility.Argument arg)
		{
		}

		public override void OnApplyReduceHp(ref EnemyAbility.Argument arg)
		{
		}

		public override void OnFatalAttack(ref EnemyAbility.Argument arg)
		{
		}

		public override void OnOverdrive(ref EnemyAbility.Argument arg)
		{
		}

		public override void OnOverdriveDamage(CollisionHitAttribute hitAttr, float od_rate, ref EnemyAbility.Argument arg)
		{
		}

		public override void OnBreak()
		{
		}

		public override void OnStateEnter_ShapeShift()
		{
		}

		public override void OnShiftIntoForm2nd()
		{
		}

		public override void OnShiftIntoOriginal()
		{
		}

		public override void OnApplyBuffDebuff(ref EnemyAbility.Argument arg)
		{
		}

		public override void OnPlayEffectBuff(ref EnemyAbility.Argument arg)
		{
		}

		public override void OnStopEffectBuff(CharacterBuff buff)
		{
		}

		public override void OnDispTextBuff(ref EnemyAbility.Argument arg)
		{
		}

		public override void OnStopBuffField(List<CharacterBase> outCharaList, ref EnemyAbility.Argument arg)
		{
		}

		public override void OnBeforeSetAbnormal(CollisionHitAttribute attr, int conditionId, ref EnemyAbility.Argument arg)
		{
		}

		public override void OnSetAbnormalStatus(CollisionHitAttribute attr, ActionConditionElement elem, CharacterBase.AbnormalStatusProbabilityResult probability)
		{
		}

		public override void OnAbnormalClearType(AbnormalStatusType type, ref EnemyAbility.Argument arg)
		{
		}

		public override void OnWeakPointDestroy(bool isPlayAction)
		{
		}

		public override void OnWeakPointDefeated(bool isPlayAction)
		{
		}

		public override void OnActionParts(bool onoff)
		{
		}

		private void SetupPrimary()
		{
		}

		private void SetupSecondary()
		{
		}

		private void ApplyDamageSecondary(CharacterDamageIntermediate damageData, bool alive)
		{
		}

		private void CheckAbnormal()
		{
		}
	}
}
