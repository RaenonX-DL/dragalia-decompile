using System.Collections.Generic;

namespace Gluon
{
	public class AbilityBase
	{
		private float lastCheckRunOptionActionTime;

		private const float runOptionActionCheckInterval = 0.3f;

		public static readonly int requiredBuffId_Wildcard;

		protected void Apply(CharacterBase owner, AbilityCondition conditionType, int type, int abilityId, int variousId, string variousStr, AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, float rate, float conditionValue)
		{
		}

		protected void Reset(CharacterBase owner, int type, AbilityTargetAction actionType, int variousId, int abilityId)
		{
		}

		protected void ApplyServitor(CharacterBase owner)
		{
		}

		protected void ApplyStatusUp(CharacterBase owner, int variousId, ref CharacterParameter.FluctuationParameter param, float rate)
		{
		}

		private void ApplyActionDamageUp(CharacterBase owner, AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, float rate)
		{
		}

		private void ApplyActionDamageDown(CharacterBase owner, AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, float rate)
		{
		}

		private void ApplyActionDamageUpDependsOnHitCount(CharacterBase owner, AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, string strDatas)
		{
		}

		private void AddActionPowerDependsOnHitCount(CharacterParameter.FluctuationParameter param, int actionType, int hitCount, float rate)
		{
		}

		public void ApplyAbnormalStatusResist(int variousId, ref CharacterParameter.FluctuationParameter param, float rate)
		{
		}

		public void ApplyAbnormalStatusAdd(CharacterBase owner, int variousId, AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, float rate)
		{
		}

		public void ApplyCriticalUp(CharacterBase owner, AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, float rate)
		{
		}

		public void ApplyCriticalUpForSkillAbility(CharacterBase owner, AbilityTargetAction actionType, AbilityTargetAction defaultActionType, ref CharacterParameter.FluctuationParameter param, float rate)
		{
		}

		public void ApplyRecoveryHpUp(CharacterBase owner, AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, float rate)
		{
		}

		public void ApplyRecoveryUpForDyingTarget(CharacterBase owner, AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, float rate)
		{
		}

		public void ApplyBreakGaugeDamageUp(CharacterBase owner, AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, float rate)
		{
		}

		public void ApplyBreakDamageUp(CharacterBase owner, AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, float rate)
		{
		}

		private void ApplyStatusUpBuffExtention(CharacterBase owner, AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, float rate)
		{
		}

		private void ApplyStatusUpDebuffExtention(CharacterBase owner, AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, float rate)
		{
		}

		private void ApplyAbnormalStatusExtention(CharacterBase owner, int variousId, AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, float rate)
		{
		}

		private void AddCriticalParamDependsOnEnemyStatus(Dictionary<int, float> criticalCrt, int type, float rate)
		{
		}

		private void ApplyCrisisRate(CharacterBase owner, AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, float rate)
		{
		}

		private void ApplyAbonormalKillerDependsOnTypeCount(CharacterBase owner, AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, string strDatas)
		{
		}

		public static bool IsMatchCondition(CharacterBase owner, WeaponType weaponType)
		{
			return default(bool);
		}

		public static bool IsMatchCondition(CharacterBase owner, int targetUnitType, int ownerUnitType, ElementalType elementalType)
		{
			return default(bool);
		}

		public static bool IsMatchCondition(CharacterBase owner, int targetUnitType, ElementalType elementalType)
		{
			return default(bool);
		}

		public static bool IsMatchCondition(CharacterBase owner, int requiredActionConditionId, int count, string conditionString)
		{
			return default(bool);
		}

		public static bool IsMatchCondition(CharacterBase owner, int disappearToEnableBuff)
		{
			return default(bool);
		}

		public static bool IsMatchCondition(CharacterBase owner, AbilityCondition conditionType, float conditionValue, float conditionValue2, int probability, AbilityTargetAction targetAction = AbilityTargetAction.NONE)
		{
			return default(bool);
		}

		public static bool IsMatchTargetAction(CharacterBase owner, AbilityTargetAction targetAction, int actionId, bool includesEnhanced = false)
		{
			return default(bool);
		}

		public static AbilityTargetAction GetTargetAction(CharacterBase actor, int actionId)
		{
			return default(AbilityTargetAction);
		}

		public static AbilityTargetAction ConvertTargetActionForSkillAbility(CharacterBase actor, AbilityTargetAction targetActionId)
		{
			return default(AbilityTargetAction);
		}

		public static bool IsEnableApplyCharacter(CharacterBase owner)
		{
			return default(bool);
		}

		public static CharacterBase GetHostileTarget(CharacterBase target)
		{
			return null;
		}
	}
}
