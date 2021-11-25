using System.Collections.Generic;
using Gluon.Master;

namespace Gluon
{
	public class FollowerAIBase
	{
		protected List<int> _tmpSkillIndexList;

		public virtual void Update(PlayerCharacter owner)
		{
		}

		public virtual bool IsEnableSkill(PlayerCharacter owner, CharacterBase target, int index)
		{
			return default(bool);
		}

		public virtual bool IsEnableSkill1(PlayerCharacter owner, CharacterBase target)
		{
			return default(bool);
		}

		public virtual bool IsEnableSkill2(PlayerCharacter owner, CharacterBase target)
		{
			return default(bool);
		}

		public virtual bool IsEnableWeaponSkill(PlayerCharacter owner, CharacterBase target)
		{
			return default(bool);
		}

		public virtual bool IsEnableSkill4(PlayerCharacter owner, CharacterBase target)
		{
			return default(bool);
		}

		public virtual bool CheckDragonSkillForAuto()
		{
			return default(bool);
		}

		public virtual bool IsPrioritizeBurstAttack(PlayerCharacter owner, CharacterBase target, float probabilityCoef = 1f, bool force = false)
		{
			return default(bool);
		}

		public virtual bool IsIgnoreCommonConditionForBurstAttack(PlayerCharacter owner)
		{
			return default(bool);
		}

		public virtual bool IsIgnorePrioritizeEnhancedBurstAttack(PlayerCharacter owner)
		{
			return default(bool);
		}

		public virtual bool ShouldCancelSkill(PlayerCharacter owner, int skillIndex)
		{
			return default(bool);
		}

		public virtual bool ShouldUseDashOnAvoid(PlayerCharacter owner)
		{
			return default(bool);
		}

		public virtual bool IsSkillAvailable(PlayerCharacter owner, int skillIndex)
		{
			return default(bool);
		}

		public virtual bool IsEnableBurstAttack(CharacterSelector selector)
		{
			return default(bool);
		}

		public virtual float GetChargeCompleteWaitSecForAI(PlayerCharacter owner, float defaultVal)
		{
			return default(float);
		}

		public virtual bool ShouldUseExCombo(PlayerCharacter owner, CharacterBase target)
		{
			return default(bool);
		}

		public virtual float GetProbabilityForBurstAttackOnOverrideMode(PlayerCharacter owner, float probability, CharacterBase target)
		{
			return default(float);
		}

		public virtual int GetChargeLevel(PlayerCharacter owner, CharacterBase target)
		{
			return default(int);
		}

		public virtual bool NeedsCheckPrioritizeBurstAttack()
		{
			return default(bool);
		}

		public virtual bool BurstAttackIsAttack()
		{
			return default(bool);
		}

		public virtual bool IsEnableTransform(PlayerCharacter owner)
		{
			return default(bool);
		}

		public virtual bool IsEnableUniqueTransform(PlayerCharacter owner)
		{
			return default(bool);
		}

		public virtual bool IsEnableServantTransform(PlayerCharacter owner)
		{
			return default(bool);
		}

		public virtual bool IsEnableReleaseUniqueTransform(PlayerCharacter owner)
		{
			return default(bool);
		}

		public virtual bool IsEnableAdditionalInputCount(PlayerCharacter owner, int counter = 0)
		{
			return default(bool);
		}

		public virtual bool AdditionalInputCountTimes(PlayerCharacter owner, int counter)
		{
			return default(bool);
		}

		public virtual bool ShouldSkipCheckComboCancel(PlayerCharacter owner, int combo)
		{
			return default(bool);
		}

		public virtual bool CheckAndSwitchMode(PlayerCharacter ownerm, CharacterBase target)
		{
			return default(bool);
		}

		public virtual PlayerActionElement GetActionDataOnCheckSkill(PlayerActionElement elem, PlayerCharacter owner, int skillIndex)
		{
			return null;
		}

		public virtual void OnSkillEnter(PlayerCharacter owner, int skillIndex)
		{
		}

		public virtual void OnSkillExit(PlayerCharacter owner, int skillIndex)
		{
		}

		public virtual void OnAttackExit(PlayerCharacter owner, int actionId)
		{
		}

		public virtual void OnTransformEnter(PlayerCharacter owner)
		{
		}

		public virtual void AvoidOnAttacked(PlayerCharacter owner, CollisionHitAttribute attr)
		{
		}

		public virtual bool IsBarrierEnemy(PlayerCharacter owner, EnemyCharacter enemy, int skillIndex)
		{
			return default(bool);
		}

		protected virtual void ChangeMode(PlayerCharacter owner, int mode)
		{
		}

		public virtual List<int> GetSkillIndexList(PlayerCharacter owner)
		{
			return null;
		}

		public virtual bool ShouldEscapeMarkerInCharge(PlayerCharacter owner)
		{
			return default(bool);
		}

		protected bool IsAIMode(PlayerCharacter owner)
		{
			return default(bool);
		}
	}
}
