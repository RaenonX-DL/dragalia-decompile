/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AbilityBase
	{
		// Constructors
		public AbilityBase();
	
		// Methods
		protected void Apply(CharacterBase owner, AbilityCondition conditionType, int type, int variousId, string variousStr, AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, float rate, float conditionValue);
		protected void Reset(CharacterBase owner, int type, AbilityTargetAction actionType, int variousId);
		protected void ApplyStatusUp(int variousId, AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, float rate);
		private void ApplyActionDamageUp(AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, float rate);
		private void ApplyActionDamageUpDependsOnHitCount(AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, string strDatas);
		private void AddActionPowerDependsOnHitCount(CharacterParameter.FluctuationParameter param, int actionType, int hitCount, float rate);
		public void ApplyAbnormalStatusResist(int variousId, ref CharacterParameter.FluctuationParameter param, float rate);
		public void ApplyAbnormalStatusAdd(int variousId, AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, float rate);
		public void ApplyCriticalUp(AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, float rate);
		public void ApplyCriticalUpForSkillAbility(CharacterBase owner, AbilityTargetAction actionType, AbilityTargetAction defaultActionType, ref CharacterParameter.FluctuationParameter param, float rate);
		public void ApplyRecoveryHpUp(AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, float rate);
		public void ApplyBreakGaugeDamageUp(AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, float rate);
		private void ApplyStatusUpBuffExtention(AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, float rate);
		private void ApplyStatusUpDebuffExtention(AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, float rate);
		private void ApplyAbnormalStatusExtention(AbilityTargetAction actionType, ref CharacterParameter.FluctuationParameter param, float rate);
		private void AddCriticalParamDependsOnEnemyStatus(Dictionary<int, float> criticalCrt, int type, float rate);
		public static bool IsMatchCondition(CharacterBase owner, WeaponType weaponType);
		public static bool IsMatchCondition(CharacterBase owner, int targetUnitType, int ownerUnitType, ElementalType elementalType);
		public static bool IsMatchCondition(CharacterBase owner, int targetUnitType, ElementalType elementalType);
		public static bool IsMatchCondition(CharacterBase owner, int requiredActionConditionId, int count);
		public static bool IsMatchCondition(CharacterBase owner, AbilityCondition conditionType, float conditionValue, float conditionValue2, int probability, AbilityTargetAction targetAction = AbilityTargetAction.NONE);
		public static bool IsMatchTargetAction(CharacterBase owner, AbilityTargetAction targetAction, int actionId);
		public static AbilityTargetAction GetTargetAction(CharacterBase actor, int actionId);
		public static AbilityTargetAction ConvertTargetActionForSkillAbility(CharacterBase actor, AbilityTargetAction targetActionId);
		public static bool IsEnableApplyCharacter(CharacterBase owner);
	}
}
