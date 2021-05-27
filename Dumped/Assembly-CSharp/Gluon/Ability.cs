/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class Ability : AbilityBase
	{
		// Fields
		private static readonly int abilityId_MachinegunBurstSpeedUp;
		private static readonly int abilityId_MachinegunBurstDisabled;
		private List<ConditionallyAbility> conditionallyAbilities;
		private AbilityMultiPlayService _multiPlayService;
		[CompilerGenerated]
		private Dictionary<AbilityTargetAction, List<int>> _dictGrant_k__BackingField;
		[CompilerGenerated]
		private AbilityLimitCalculation _limitAmulet_k__BackingField;
		[CompilerGenerated]
		private AbilityLimitCalculation _limitUnionBonus_k__BackingField;
		private CharacterParameter.FluctuationParameter workAbilityAddParam;
		private CharacterParameter.FluctuationParameter workPrevAbilityAddParam;
		private List<float> tmpAbnormalResistRateList;
		private bool _enableUpdate;
		[CompilerGenerated]
		private bool _forceRecalc_k__BackingField;
		private CauseDebuffData causeDebuffData;
		[CompilerGenerated]
		private CharacterBuffType _causeDebuffType_k__BackingField;
		private List<int> displayedShiftGroupIdList;
	
		// Properties
		public Dictionary<AbilityTargetAction, List<int>> dictGrant { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public AbilityLimitCalculation limitAmulet { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public AbilityLimitCalculation limitUnionBonus { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool enableUpdate { get; set; }
		public bool forceRecalc { [CompilerGenerated] get; [CompilerGenerated] set; }
		public CharacterBuffType causeDebuffType { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public class CauseDebuffData
		{
			// Fields
			public int actionId;
			public int productId;
	
			// Constructors
			public CauseDebuffData();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass41_0
		{
			// Fields
			public Ability __4__this;
			public CharacterBase current;
	
			// Constructors
			public __c__DisplayClass41_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass41_1
		{
			// Fields
			public ConditionallyAbility ability;
			public __c__DisplayClass41_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass41_1();
	
			// Methods
			internal void _ApplyConditionally_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass76_0
		{
			// Fields
			public CharacterBase owner;
	
			// Constructors
			public __c__DisplayClass76_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass76_1
		{
			// Fields
			public ConditionallyAbility ability;
			public __c__DisplayClass76_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass76_1();
	
			// Methods
			internal void _CheckConditionallyAbility_b__0();
		}
	
		// Constructors
		public Ability();
		static Ability();
	
		// Methods
		public void Initialize(CharacterBase original, CharacterBase current);
		public bool Update(CharacterBase original, CharacterBase current, bool timerUpdate);
		public void SetMultiPlayService(AbilityMultiPlayService multiPlayService);
		public void WriteSyncData(List<AbilitySyncData> outData);
		public void ReadSyncData(List<AbilitySyncData> data);
		private void ApplyAlways(CharacterBase owner, CharacterBase curr, AbilityDataElement ade, int ownerUnit, int ownerId);
		private bool NeedApplyConditionallyToOtherPlayer(ConditionallyAbility ability);
		private bool ApplyConditionally(CharacterBase current, bool timerUpdate);
		private void Apply(CharacterBase owner, AbilityDataElement ade, ref CharacterParameter.FluctuationParameter param, int idx, int count, int ownerUnit, int ownerId);
		private AbilityTargetAction ConvertTargetActionForShareSkill(AbilityTargetAction actionType, PlayerCharacter player, AbilityConst.UnitType ownerUnit, int ownerId);
		private void Reset(CharacterBase owner, AbilityDataElement ade, int idx);
		private bool ApplyMoment(CharacterBase owner, CharacterBase from, CharacterBase hostile, ConditionallyAbility ability, int actionId, int idx, int skillId, int healValue, out bool isSkipHeadText);
		private bool ApplyMoment(CharacterBase owner, CharacterBase from, CharacterBase hostile, AbilityDataElement ade, int actionId, int idx, int count, Dictionary<int, float> mixedBuffDict, int skillId, int ownerId, int healValue, out bool isSkipHeadText);
		public void SendApplyAbilityEvent(CharacterBase owner, AbilityDataElement ade, int idx, int count);
		public void OnRecieveApplyAbilityEvent(CharacterBase owner, ApplyAbilityEvent recvEvent);
		private void ApplyMomentForAmulet(CharacterBase owner, AbilityConst.Type type, float value);
		private bool ApplyBuffFromHitAttribute(CharacterBase owner, AbilityDataElement ade, int actionId, int idx, int skillId = 0, bool isLink = false);
		private bool ApplyDpCharge(CharacterBase owner, float value);
		public static void Apply(CharacterBase owner, AbilityConst.Type type, int actionId, Action<AbilityDataElement, int> applyFunc);
		private static void Apply(CharacterBase owner, AbilityDataElement ade, int type, int actionId, int ownerUnit, Action<AbilityDataElement, int> applyFunc);
		public static bool IsMatchCondition(CharacterBase owner, AbilityDataElement ade, int type, int actionId, int idx, int ownerUnit);
		private static bool IsMatchCondition(CharacterBase owner, AbilityDataElement ade, int actionId, int idx, int ownerUnit);
		public static int GetType(AbilityDataElement ade, int idx);
		public static bool HasType(AbilityDataElement ade, int idx, AbilityConst.Type abilityType);
		public static int GetVariousId(AbilityDataElement ade, int idx, int count);
		public ActionTargetGroup GetTargetGroup(AbilityDataElement ade, int idx);
		private int GetRandomVariousId(AbilityDataElement ade, int idx);
		private List<int> GetRandomVariousIds(AbilityDataElement ade, int idx, int num);
		private void AddRandomList(List<int> list, int id);
		public static string GetVariousString(AbilityDataElement ade, int idx);
		public static List<AbnormalStatusType> GetVariousStringAsAbnormalStatus(AbilityDataElement ade, int idx);
		public static int GetLimitedGroup(AbilityDataElement ade, int idx);
		public static float GetLimitValue(AbilityDataElement ade, int idx);
		public static AbilityTargetAction GetTargetAction(AbilityDataElement ade, int idx);
		public static float GetValue(AbilityDataElement ade, int idx, CharacterBase owner = null);
		private bool IsLinkCondition(AbilityCondition condition);
		public void CalcLimitedValueForAmulet(CharacterBase original);
		public void CalcLimitedValueForUnionBonus(CharacterBase original);
		public List<ConditionallyAbility> SetupConditionallyAbility(HumanCharacter owner);
		public void SetupConditionallyAbilityForExAbility2(HumanCharacter owner);
		public void AddConditionallyAbilityList(AbilityDataElement ade, AbilityConst.UnitType unitType, int unitId);
		private void MixBuffAbility(AbilityConst.UnitType unitType);
		public bool CheckConditionallyAbility(CharacterBase owner, CharacterBase from, AbilityCondition conditionType, int actionId, int skillIndex = 0, int conditionValue = 0, int skillId = 0, int requiredActionConditionId = 0, CharacterBase hostile = null, int conditionValue2 = 0, string conditionString = null, int healValue = 0);
		public void CheckConditionalAbilityForResetCoolDown(ConditionallyAbility ability);
		public void CheckCauseDebuffConditionallyAbility(CharacterBase owner, CharacterBase from, CharacterBuffType type, int actionId, int productId);
		public void CheckExpireAbility(CharacterBase owner, AbilityConst.ExpireType expireType);
		public bool IsValidatedResistAbs(CharacterBase owner);
		public void ResetAllConditionallyAbility(CharacterBase owner, bool canNotRebornButCanContinueDeath = false);
		public void ResetConditionallyAbility(CharacterBase owner, AbilityCondition condition);
		private void ResetChargeTimeMoreMoment(CharacterBase owner, AbilityCondition condition);
		public void ResetCoolTime(bool resetReactionTimeToMax);
		public void PauseCoolTime(bool isPause, AbilityCondition condition);
		public void TriggerCoolTime(int abilityId);
		public void RegistGrant(int grantId);
		private bool IsConditinallyBuffAbility(ConditionallyAbility condAbility, int idx);
		private void ApplyConditinallyBuffAbility(CharacterBase owner, ConditionallyAbility condAbility, int idx, int count, Dictionary<int, float> mixedBuffDict = null, bool isRestoreBuff = false);
		private void RestoreConditinallyBuffAbility(CharacterBase owner, ConditionallyAbility condAbility, int idx, int count, bool isReborn, Dictionary<int, float> mixedBuffDict = null);
		private void RemoveConditionallyBuffAbility(CharacterBase owner, ConditionallyAbility condAbility, int idx, RemoveBuffReason reason);
		private bool HasBuffDebuffByBuffAbility(CharacterBase owner, ConditionallyAbility condAbility, int idx, int cnt);
		public static void HasInvalidAbility(ref bool isInvalid1, ref bool isInvalid2, CharacterBase owner, AbilityConst.Type abilityType, AbilityDataElement ade, int ownerUnit);
		public static bool HasAbility(CharacterBase owner, AbilityConst.Type abilityType, AbilityDataElement ade, int ownerUnit, out int idx, out int variousId);
		public bool HasConditionallyAbility(AbilityCondition conditionType, bool checkCoolTime);
		public bool HasConditionallyAbility(int abilityId, out ConditionallyAbility ability);
		public bool HasDragonMode2Ability(CharacterBase owner);
		public bool HasHitAttributeShiftAbility(CharacterBase owner);
		public bool IsMatchHitAttributeShiftCondition(CharacterBase owner);
		private void DisplayUICallbackByConditionallyAbility(CharacterBase current, ConditionallyAbility ability, Action onDisplayUI);
		private void DisplayUIByConditionallyAbility(CharacterBase current, ConditionallyAbility ability, CharacterParameter.FluctuationParameter param = null, AbilityConst.Type skipAbilityType = AbilityConst.Type.None, AbilityConst.Type targetAbilityType = AbilityConst.Type.None);
		public static bool GetAbilityDataFromHitAttrId(CharacterBase chara, string hitAttrId, out AbilityDataElement hitAttrAde);
		private static bool GetAbilityDataFromHitAttrId(AbilityDataElement ade, string hitAttrId, ref AbilityDataElement hitAttrAde);
		public static bool GetGrantAbilityDataFromConditionID(CharacterBase chara, int conditionId, out AbilityDataElement grantAde);
		private static bool IsGrantAbilityData(AbilityDataElement ade, int conditionId);
		public static bool GetAbilityTypeFromConditionID(AbilityDataElement ade, int conditionId, out AbilityConst.Type abilityType);
		public void RestoreConditinallyAbilityBuff(CharacterBase owner, bool isReborn);
	}
}
