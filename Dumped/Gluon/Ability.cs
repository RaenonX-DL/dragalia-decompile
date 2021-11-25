using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.Event;
using Gluon.Master;

namespace Gluon
{
	public class Ability : AbilityBase
	{
		public class CauseDebuffData
		{
			public int actionId;

			public int productId;
		}

		private static readonly int abilityId_MachinegunBurstSpeedUp;

		private static readonly int abilityId_MachinegunBurstDisabled;

		private List<ConditionallyAbility> conditionallyAbilities;

		private AbilityMultiPlayService _multiPlayService;

		private CharacterParameter.FluctuationParameter workAbilityAddParam;

		private CharacterParameter.FluctuationParameter workPrevAbilityAddParam;

		private List<float> tmpAbnormalResistRateList;

		private bool _enableUpdate;

		private List<int> displayedShiftGroupIdList;

		public Dictionary<AbilityTargetAction, List<int>> dictGrant
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

		public AbilityLimitCalculation limitAmulet
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

		public AbilityLimitCalculation limitUnionBonus
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

		public bool enableUpdate
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool forceRecalc
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public CauseDebuffData causeDebuffData
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

		public CharacterBuffType causeDebuffType
		{
			[CompilerGenerated]
			get
			{
				return default(CharacterBuffType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void Initialize(CharacterBase original, CharacterBase current)
		{
		}

		public bool Update(CharacterBase original, CharacterBase current, bool timerUpdate)
		{
			return default(bool);
		}

		public void SetMultiPlayService(AbilityMultiPlayService multiPlayService)
		{
		}

		public void WriteSyncData(List<AbilitySyncData> outData)
		{
		}

		public void ReadSyncData(List<AbilitySyncData> data)
		{
		}

		private void ApplyAlways(CharacterBase owner, CharacterBase curr, AbilityDataElement ade, int ownerUnit, int ownerId)
		{
		}

		private bool NeedApplyConditionallyToOtherPlayer(ConditionallyAbility ability)
		{
			return default(bool);
		}

		private bool ApplyConditionally(CharacterBase current, bool timerUpdate)
		{
			return default(bool);
		}

		private void Apply(CharacterBase owner, AbilityDataElement ade, ref CharacterParameter.FluctuationParameter param, int idx, int count, int ownerUnit, int ownerId)
		{
		}

		private AbilityTargetAction ConvertTargetActionForShareSkill(AbilityTargetAction actionType, PlayerCharacter player, AbilityConst.UnitType ownerUnit, int ownerId)
		{
			return default(AbilityTargetAction);
		}

		private void Reset(CharacterBase owner, AbilityDataElement ade, int idx)
		{
		}

		private bool ApplyMoment(CharacterBase owner, CharacterBase from, CharacterBase hostile, ConditionallyAbility ability, int actionId, int idx, int skillId, int healValue, out bool isSkipHeadText)
		{
			return default(bool);
		}

		private bool ApplyMoment(CharacterBase owner, CharacterBase from, CharacterBase hostile, AbilityDataElement ade, int actionId, int idx, int count, Dictionary<int, float> mixedBuffDict, int skillId, int ownerId, int healValue, out bool isSkipHeadText)
		{
			return default(bool);
		}

		public void SendConsumeUtpToRecoverHpEvent(CharacterBase owner, int recoveryHp)
		{
		}

		public void OnRecieveConsumeUtpToRecoverHpEvent(CharacterBase owner, ConsumeUtpToRecoverHpEvent recvEvent)
		{
		}

		public void SendApplyAbilityEvent(CharacterBase owner, AbilityDataElement ade, int idx, int count)
		{
		}

		public void OnRecieveApplyAbilityEvent(CharacterBase owner, ApplyAbilityEvent recvEvent)
		{
		}

		private void ApplyMomentForAmulet(CharacterBase owner, AbilityConst.Type type, float value)
		{
		}

		private bool ApplyBuffFromHitAttribute(CharacterBase owner, AbilityDataElement ade, int actionId, int idx, int skillId = 0, bool isLink = false)
		{
			return default(bool);
		}

		private bool ApplyDpCharge(CharacterBase owner, float value)
		{
			return default(bool);
		}

		public void SetDpCapRate(CharacterBase owner)
		{
		}

		public static void Apply(CharacterBase owner, AbilityConst.Type type, int actionId, Action<AbilityDataElement, int> applyFunc)
		{
		}

		private static void Apply(CharacterBase owner, AbilityDataElement ade, int type, int actionId, int ownerUnit, Action<AbilityDataElement, int> applyFunc)
		{
		}

		public static bool IsMatchCondition(CharacterBase owner, AbilityDataElement ade, int type, int actionId, int idx, int ownerUnit)
		{
			return default(bool);
		}

		private static bool IsMatchCondition(CharacterBase owner, AbilityDataElement ade, int actionId, int idx, int ownerUnit)
		{
			return default(bool);
		}

		public static int GetType(AbilityDataElement ade, int idx)
		{
			return default(int);
		}

		public static bool HasType(AbilityDataElement ade, int idx, AbilityConst.Type abilityType)
		{
			return default(bool);
		}

		public static int GetVariousId(AbilityDataElement ade, int idx, int count)
		{
			return default(int);
		}

		public ActionTargetGroup GetTargetGroup(AbilityDataElement ade, int idx)
		{
			return default(ActionTargetGroup);
		}

		private int GetRandomVariousId(AbilityDataElement ade, int idx)
		{
			return default(int);
		}

		private List<int> GetRandomVariousIds(AbilityDataElement ade, int idx, int num)
		{
			return null;
		}

		private void AddRandomList(List<int> list, int id)
		{
		}

		public static string GetVariousString(AbilityDataElement ade, int idx)
		{
			return null;
		}

		public static List<AbnormalStatusType> GetVariousStringAsAbnormalStatus(AbilityDataElement ade, int idx)
		{
			return null;
		}

		public static int GetLimitedGroup(AbilityDataElement ade, int idx)
		{
			return default(int);
		}

		public static float GetLimitValue(AbilityDataElement ade, int idx)
		{
			return default(float);
		}

		public static AbilityTargetAction GetTargetAction(AbilityDataElement ade, int idx)
		{
			return default(AbilityTargetAction);
		}

		public static float GetValue(AbilityDataElement ade, int idx, [Optional] CharacterBase owner)
		{
			return default(float);
		}

		private bool IsLinkCondition(AbilityCondition condition)
		{
			return default(bool);
		}

		public void CalcLimitedValueForAmulet(CharacterBase original)
		{
		}

		public void CalcLimitedValueForUnionBonus(CharacterBase original)
		{
		}

		public List<ConditionallyAbility> SetupConditionallyAbility(HumanCharacter owner)
		{
			return null;
		}

		public void SetupConditionallyAbilityForExAbility2(HumanCharacter owner)
		{
		}

		public void AddConditionallyAbilityList(AbilityDataElement ade, AbilityConst.UnitType unitType, int unitId)
		{
		}

		private void MixBuffAbility(AbilityConst.UnitType unitType)
		{
		}

		public bool CheckConditionallyAbility(CharacterBase owner, CharacterBase from, AbilityCondition conditionType, int actionId, int skillIndex = 0, int conditionValue = 0, int skillId = 0, int requiredActionConditionId = 0, [Optional] CharacterBase hostile, int conditionValue2 = 0, [Optional] string conditionString, int healValue = 0, RemoveBuffReason buffDisappearedReason = RemoveBuffReason.Other)
		{
			return default(bool);
		}

		public void CheckConditionalAbilityForResetCoolDown(ConditionallyAbility ability)
		{
		}

		public void CheckCauseDebuffConditionallyAbility(CharacterBase owner, CharacterBase from, CharacterBuffType type, int actionId, int productId, [Optional] CharacterBase receiver)
		{
		}

		public void CheckExpireAbility(CharacterBase owner, AbilityConst.ExpireType expireType)
		{
		}

		public bool IsValidatedResistAbs(CharacterBase owner)
		{
			return default(bool);
		}

		public void ResetAllConditionallyAbility(CharacterBase owner, bool canNotRebornButCanContinueDeath = false)
		{
		}

		public void ResetConditionallyAbility(CharacterBase owner, AbilityCondition condition, int conditionValue = -1)
		{
		}

		private void ResetChargeTimeMoreMoment(CharacterBase owner, AbilityCondition condition)
		{
		}

		public void ResetCoolTime(bool resetReactionTimeToMax)
		{
		}

		public void PauseCoolTime(bool isPause, AbilityCondition condition)
		{
		}

		public void TriggerCoolTime(int abilityId)
		{
		}

		public void RegistGrant(int grantId)
		{
		}

		public void StartSupportSkill(float elapsedTime)
		{
		}

		private bool IsConditinallyBuffAbility(ConditionallyAbility condAbility, int idx)
		{
			return default(bool);
		}

		private void ApplyConditinallyBuffAbility(CharacterBase owner, ConditionallyAbility condAbility, int idx, int count, [Optional] Dictionary<int, float> mixedBuffDict, bool isRestoreBuff = false)
		{
		}

		private void RestoreConditinallyBuffAbility(CharacterBase owner, ConditionallyAbility condAbility, int idx, int count, bool isReborn, [Optional] Dictionary<int, float> mixedBuffDict)
		{
		}

		private void RemoveConditionallyBuffAbility(CharacterBase owner, ConditionallyAbility condAbility, int idx, RemoveBuffReason reason)
		{
		}

		private bool HasBuffDebuffByBuffAbility(CharacterBase owner, ConditionallyAbility condAbility, int idx, int cnt)
		{
			return default(bool);
		}

		public static void HasInvalidAbility(ref bool isInvalid1, ref bool isInvalid2, CharacterBase owner, AbilityConst.Type abilityType, AbilityDataElement ade, int ownerUnit)
		{
		}

		public static bool HasAbility(CharacterBase owner, AbilityConst.Type abilityType, AbilityDataElement ade, int ownerUnit, out int idx, out int variousId)
		{
			return default(bool);
		}

		public bool HasConditionallyAbility(AbilityCondition conditionType, bool checkCoolTime)
		{
			return default(bool);
		}

		public bool HasConditionallyAbility(int abilityId, out ConditionallyAbility ability)
		{
			return default(bool);
		}

		public bool HasConditionallyAbilityForRequiredBuffWildcard(out ConditionallyAbility ability)
		{
			return default(bool);
		}

		public List<ConditionallyAbility> GetConditionallyAbilities(AbilityCondition conditionType)
		{
			return null;
		}

		public bool HasDragonMode2Ability(CharacterBase owner)
		{
			return default(bool);
		}

		public bool HasHitAttributeShiftAbility(CharacterBase owner)
		{
			return default(bool);
		}

		public bool IsMatchHitAttributeShiftCondition(CharacterBase owner)
		{
			return default(bool);
		}

		private void DisplayUICallbackByConditionallyAbility(CharacterBase current, ConditionallyAbility ability, Action onDisplayUI)
		{
		}

		private void DisplayUIByConditionallyAbility(CharacterBase current, ConditionallyAbility ability, [Optional] CharacterParameter.FluctuationParameter param, AbilityConst.Type skipAbilityType = AbilityConst.Type.None, AbilityConst.Type targetAbilityType = AbilityConst.Type.None)
		{
		}

		public static bool GetAbilityDataFromHitAttrId(CharacterBase chara, string hitAttrId, out AbilityDataElement hitAttrAde)
		{
			return default(bool);
		}

		private static bool GetAbilityDataFromHitAttrId(AbilityDataElement ade, string hitAttrId, ref AbilityDataElement hitAttrAde)
		{
			return default(bool);
		}

		public static bool GetGrantAbilityDataFromConditionID(CharacterBase chara, int conditionId, out AbilityDataElement grantAde)
		{
			return default(bool);
		}

		private static bool IsGrantAbilityData(AbilityDataElement ade, int conditionId)
		{
			return default(bool);
		}

		public static bool GetAbilityTypeFromConditionID(AbilityDataElement ade, int conditionId, out AbilityConst.Type abilityType)
		{
			return default(bool);
		}

		public void RestoreConditinallyAbilityBuff(CharacterBase owner, bool isReborn)
		{
		}
	}
}
