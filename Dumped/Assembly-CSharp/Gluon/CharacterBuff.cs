/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Bullet;
using Gluon.Event;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterBuff
	{
		// Fields
		private static CharacterBuffType[] _typeListForPopulation;
		private static readonly int enumRegenerationTypeCount;
		public static readonly int enumActionDefDebuffCount;
		public static readonly int tensionMaxLevel;
		public static readonly int inspirationMaxLevel;
		public static readonly int malaiseMaxLevel;
		public static readonly int dbfGashDamageGroupId;
		private List<int> uniqueIconDisplayedList;
		[CompilerGenerated]
		private float[] _shieldUserHp_k__BackingField;
		[CompilerGenerated]
		private float _sacrificeShieldHp_k__BackingField;
		public float sacrificeShieldMaxHp;
		[CompilerGenerated]
		private float _sacrificeShieldConsumeHp_k__BackingField;
		private int tensionLevelBeforeApply;
		private int inspirationLevelBeforeApply;
		private List<BuffUnion> skillDamageUpBuffsOnSkillStart;
		[CompilerGenerated]
		private float _skillDamageUpRateOnSkillStart_k__BackingField;
		private static readonly CharacterBuffType[] excludeTypes;
		[CompilerGenerated]
		private CharacterBuffCoolDownController _coolDownController_k__BackingField;
		public List<Parameter> notRemoveDebufList;
		public List<int> removedBuffUnionList;
		public List<Parameter> tmpHpRecoverdRemovedBuffDebuffs;
		[CompilerGenerated]
		private Action<CharacterBuffType, Parameter> _onBuffDebuffApplied_k__BackingField;
		private List<Regeneration> removeRegeneList;
		public List<int> tmpRegeneGroups;
		public float tmpRegeneDragonTimerDamage;
		private const int defaultBuffDebuffsMaxCount = 20;
		private Dictionary<CharacterBuffType, List<Parameter>> buffDebuffDic;
		private Dictionary<int, List<UnifiedParameter>> unifiedDic;
		private List<int> resetSkillIds;
		private Dictionary<CharacterBuffType, List<Regeneration>> regenerationDic;
		[CompilerGenerated]
		private List<GrantData> _comboGrant_k__BackingField;
		[CompilerGenerated]
		private List<GrantData> _burstGrant_k__BackingField;
		[CompilerGenerated]
		private List<GrantData> _skill1Grant_k__BackingField;
		[CompilerGenerated]
		private List<GrantData> _skill2Grant_k__BackingField;
		[CompilerGenerated]
		private List<GrantData> _skillAllGrant_k__BackingField;
		private Dictionary<int, List<GrantData>> _grantListDic;
		private static readonly int hitDataMax;
		public List<CharacterHitData> hitDataList;
		private CharacterHitData[] hitData;
		private ValidEffectChecker validEffect;
		private CollisionHitAttribute _hitAttr;
		private string _hitAttrId;
		private ActionTargetGroup _hitAttrTargetGroup;
		private ActionStartParameter _hitAttrActionStartParam;
		private CharacterParameter.FluctuationParameter baseParam;
		private BuffMultiPlayService _multiPlayService;
		[CompilerGenerated]
		private CharacterTriggerCtrl _BuffTriggerCtrl_k__BackingField;
		[CompilerGenerated]
		private CharacterBuffRestoreCtrl _BuffRestoreCtrl_k__BackingField;
		private Dictionary<CharacterBase, int> regeneratorDict;
		private List<int> normalIconIdList;
		private List<int> uniqueIconIdList;
		private static bool hasBuffDebuffCheckResult;
		private static int specificBuffCheckCount;
		private static int specificBuffCheckId;
		private static float specificBuffFloatVal;
	
		// Properties
		public static CharacterBuffType[] typeListForPopulation { get; }
		public float[] shieldUserHp { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float sacrificeShieldHp { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float sacrificeShieldConsumeHp { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float skillDamageUpRateOnSkillStart { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public CharacterBuffCoolDownController coolDownController { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Action<CharacterBuffType, Parameter> onBuffDebuffApplied { [CompilerGenerated] get; [CompilerGenerated] set; }
		public List<GrantData> comboGrant { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public List<GrantData> burstGrant { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public List<GrantData> skill1Grant { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public List<GrantData> skill2Grant { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public List<GrantData> skillAllGrant { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public BuffMultiPlayService MultiPlayService { get; }
		public CharacterTriggerCtrl BuffTriggerCtrl { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public CharacterBuffRestoreCtrl BuffRestoreCtrl { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public static class EfficacyType
		{
			// Fields
			public const int Add = 0;
			public const int RemoveTypeAll = 1;
			public const int RemoveStack = 2;
			public const int RemoveBuffAll = 97;
			public const int RemoveDebuffAll = 98;
			public const int RemoveAll = 99;
			public const int Dispel = 100;
		}
	
		public struct BuffUnion
		{
			// Fields
			public BuffCategories category;
			public CharacterBuffType type;
			public AbilityTargetAction targetAction;
			public Parameter paramBuff;
			public UnifiedParameter unifiedBuff;
			public Regeneration regene;
			public GrantData grant;
	
			// Properties
			public int ActionConditionId { get; }
			public int AbilityId { get; }
	
			// Nested types
			public enum BuffCategories
			{
				None = 0,
				NormalParameter = 1,
				UnifiedParameter = 2,
				Regeneration = 3,
				Grant = 4
			}
	
			// Methods
			public static BuffUnion None();
			public void Clear();
			public static BuffUnion FromNormalParameterBuff(CharacterBuffType type, Parameter buff);
			public static BuffUnion FromUnifiedParameterBuff(UnifiedParameter buff);
			public static BuffUnion FromRegeneration(CharacterBuffType type, Regeneration buff);
			public static BuffUnion FromGrant(AbilityTargetAction targetAction, GrantData buff);
		}
	
		private class TypeComparer : IEqualityComparer<CharacterBuffType>
		{
			// Constructors
			public TypeComparer();
	
			// Methods
			public bool Equals(CharacterBuffType x, CharacterBuffType y);
			public int GetHashCode(CharacterBuffType obj);
		}
	
		private enum RegenerationType
		{
			Hp = 0,
			Sp = 1,
			Dp = 2,
			SlipHp = 3,
			AutoS2 = 4,
			AutoS1 = 5,
			AutoSW = 6
		}
	
		public enum ActionDefDebuff
		{
			None = 0,
			Hp = 1,
			Attack = 2,
			Defense = 3,
			Critical = 4,
			SkillDamage = 5,
			BurstDamage = 6,
			Recovery = 7,
			Regeneration = 8,
			ElementalResist = 9,
			EnhancedBurst = 10,
			EnhancedSkill = 11,
			AttackSpeed = 12,
			EnhancedAttack = 13,
			Hp_Attack = 14,
			CriticalDamage = 15,
			SlipHp = 16,
			Nicked = 17,
			Malaise = 18,
			SPDamage = 19,
			DisableAction = 20,
			AttackOrDefense = 21
		}
	
		private enum AuraID
		{
			None = 0,
			Common = 1
		}
	
		public enum ElementalBitShift
		{
			None = 0,
			Fire = 1,
			Water = 2,
			Wind = 4,
			Light = 8,
			Dark = 16
		}
	
		[Flags]
		public enum SkillIndexBitShift
		{
			None = 0,
			Skill_1 = 1,
			Skill_2 = 2,
			Skill_3 = 4,
			Skill_4 = 8
		}
	
		public enum RemoveAction
		{
			None = 0,
			DragonShift = 1,
			WeaponSkill = 2,
			SupportSkill = 3,
			ShareSkill = 4
		}
	
		private enum BlockExaustFlag
		{
			None = 0,
			InAnySkill = 1,
			InTransform = 2
		}
	
		[Flags]
		public enum GrantAttribute
		{
			None = 0,
			DragonAttack = 1
		}
	
		public class Parameter
		{
			// Fields
			[CompilerGenerated]
			private CharacterBase _from_k__BackingField;
			[CompilerGenerated]
			private int _actionId_k__BackingField;
			[CompilerGenerated]
			private int _skillId_k__BackingField;
			[CompilerGenerated]
			private int _productId_k__BackingField;
			[CompilerGenerated]
			private int _ownerId_k__BackingField;
			[CompilerGenerated]
			private int _count_k__BackingField;
			[CompilerGenerated]
			private int _grantId_k__BackingField;
			[CompilerGenerated]
			private float _rate_k__BackingField;
			[CompilerGenerated]
			private float _durationSec_k__BackingField;
			[CompilerGenerated]
			private int _durationTimeScale_k__BackingField;
			[CompilerGenerated]
			private float _lifeSec_k__BackingField;
			[CompilerGenerated]
			private int _durationNum_k__BackingField;
			[CompilerGenerated]
			private int _maxDurationNum_k__BackingField;
			[CompilerGenerated]
			private int _uniqueBuffIcon_k__BackingField;
			[CompilerGenerated]
			private float _coolDownTimeSec_k__BackingField;
			[CompilerGenerated]
			private InternalFlagType _internalFlag_k__BackingField;
			[CompilerGenerated]
			private DurationType _durationType_k__BackingField;
			[CompilerGenerated]
			private int _multiPlayKey_k__BackingField;
			[CompilerGenerated]
			private int _conditionId_k__BackingField;
			[CompilerGenerated]
			private int _abilityId_k__BackingField;
			[CompilerGenerated]
			private ActionTargetGroup _hitTargetGroup_k__BackingField;
			[CompilerGenerated]
			private string _linkHitAttr_k__BackingField;
			[CompilerGenerated]
			private string _additionAttackHitAttr_k__BackingField;
			[CompilerGenerated]
			private bool _curseOfEmptinessInvalid_k__BackingField;
			[CompilerGenerated]
			private int _requiredRecoverHpToDeleteThisBuff_k__BackingField;
			[CompilerGenerated]
			private int _requiredRecoverHpCount_k__BackingField;
	
			// Properties
			public CharacterBase from { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public int actionId { [CompilerGenerated] get; [CompilerGenerated] set; }
			public int skillId { [CompilerGenerated] get; [CompilerGenerated] set; }
			public int productId { [CompilerGenerated] get; [CompilerGenerated] set; }
			public int ownerId { [CompilerGenerated] get; [CompilerGenerated] set; }
			public int count { [CompilerGenerated] get; [CompilerGenerated] set; }
			public int grantId { [CompilerGenerated] get; [CompilerGenerated] set; }
			public float rate { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public float durationSec { [CompilerGenerated] get; [CompilerGenerated] set; }
			public int durationTimeScale { [CompilerGenerated] get; [CompilerGenerated] set; }
			public float lifeSec { [CompilerGenerated] get; [CompilerGenerated] set; }
			public int durationNum { [CompilerGenerated] get; [CompilerGenerated] set; }
			public int maxDurationNum { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public int uniqueBuffIcon { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public float coolDownTimeSec { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public InternalFlagType internalFlag { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public DurationType durationType { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public int multiPlayKey { [CompilerGenerated] get; [CompilerGenerated] set; }
			public int conditionId { [CompilerGenerated] get; [CompilerGenerated] set; }
			public int abilityId { [CompilerGenerated] get; [CompilerGenerated] set; }
			public ActionTargetGroup hitTargetGroup { [CompilerGenerated] get; [CompilerGenerated] set; }
			public string linkHitAttr { [CompilerGenerated] get; [CompilerGenerated] set; }
			public string additionAttackHitAttr { [CompilerGenerated] get; [CompilerGenerated] set; }
			public bool curseOfEmptinessInvalid { [CompilerGenerated] get; [CompilerGenerated] set; }
			public int requiredRecoverHpToDeleteThisBuff { [CompilerGenerated] get; [CompilerGenerated] set; }
			public int requiredRecoverHpCount { [CompilerGenerated] get; [CompilerGenerated] set; }
			public virtual bool isBuff { get; }
	
			// Nested types
			public enum DurationType
			{
				None = 0,
				Time = 1,
				Num = 2,
				Both = 3,
				UntilDead = 4
			}
	
			[Flags]
			public enum InternalFlagType
			{
				Normal = 0,
				NoIcon = 1,
				NoCount = 2
			}
	
			// Constructors
			public Parameter();
	
			// Methods
			public virtual void Reset(CharacterBase owner);
			public void Set(CharacterBase from, int actionId, int skillId, int productId, int ownerId, int count, int enhancedId, float rate, float durationSec, int durationNum, int maxDurationNum, int durationTimeScale, float coolDownTimeSec, int conditionId, int uniqueBuffIcon, int abilityId, ActionTargetGroup hitTargetGroup, int curseOfEmptinessInvalid, int requiredRecoverHp);
		}
	
		public class UnifiedParameter : Parameter
		{
			// Fields
			public Dictionary<CharacterBuffType, float> rateDic;
			private bool? _isBuff;
	
			// Properties
			public override bool isBuff { get; }
	
			// Constructors
			public UnifiedParameter();
	
			// Methods
			public override void Reset(CharacterBase owner);
		}
	
		public class Regeneration
		{
			// Fields
			[CompilerGenerated]
			private float _duration_k__BackingField;
			[CompilerGenerated]
			private float _life_k__BackingField;
			[CompilerGenerated]
			private float _interval_k__BackingField;
			[CompilerGenerated]
			private float _intervalTimer_k__BackingField;
			[CompilerGenerated]
			private float _healValue1_k__BackingField;
			[CompilerGenerated]
			private float _healValue2_k__BackingField;
			[CompilerGenerated]
			private float _healValue3_k__BackingField;
			[CompilerGenerated]
			private float _healValue4_k__BackingField;
			[CompilerGenerated]
			private float _rate_k__BackingField;
			[CompilerGenerated]
			private int _multiPlayKey_k__BackingField;
			[CompilerGenerated]
			private int _conditionId_k__BackingField;
			[CompilerGenerated]
			private int _abilityId_k__BackingField;
			[CompilerGenerated]
			private int _skillId_k__BackingField;
			[CompilerGenerated]
			private int _productId_k__BackingField;
			[CompilerGenerated]
			private float _rateIncreaseByTime_k__BackingField;
			[CompilerGenerated]
			private float _rateIncreaseByTimeTimer_k__BackingField;
			[CompilerGenerated]
			private float _rateIncreaseDuration_k__BackingField;
			[CompilerGenerated]
			private float _increaseRate_k__BackingField;
			[CompilerGenerated]
			private int _slipDamageGroup_k__BackingField;
			[CompilerGenerated]
			private CharacterBase _from_k__BackingField;
			[CompilerGenerated]
			private ActionTargetGroup _hitTargetGroup_k__BackingField;
			[CompilerGenerated]
			private int _uniqueIconType_k__BackingField;
			[CompilerGenerated]
			private bool _isBuff_k__BackingField;
	
			// Properties
			public float duration { [CompilerGenerated] get; [CompilerGenerated] set; }
			public float life { [CompilerGenerated] get; [CompilerGenerated] set; }
			public float interval { [CompilerGenerated] get; [CompilerGenerated] set; }
			public float intervalTimer { [CompilerGenerated] get; [CompilerGenerated] set; }
			public float healValue1 { [CompilerGenerated] get; [CompilerGenerated] set; }
			public float healValue2 { [CompilerGenerated] get; [CompilerGenerated] set; }
			public float healValue3 { [CompilerGenerated] get; [CompilerGenerated] set; }
			public float healValue4 { [CompilerGenerated] get; [CompilerGenerated] set; }
			public float rate { [CompilerGenerated] get; [CompilerGenerated] set; }
			public int multiPlayKey { [CompilerGenerated] get; [CompilerGenerated] set; }
			public int conditionId { [CompilerGenerated] get; [CompilerGenerated] set; }
			public int abilityId { [CompilerGenerated] get; [CompilerGenerated] set; }
			public int skillId { [CompilerGenerated] get; [CompilerGenerated] set; }
			public int productId { [CompilerGenerated] get; [CompilerGenerated] set; }
			public float rateIncreaseByTime { [CompilerGenerated] get; [CompilerGenerated] set; }
			public float rateIncreaseByTimeTimer { [CompilerGenerated] get; [CompilerGenerated] set; }
			public float rateIncreaseDuration { [CompilerGenerated] get; [CompilerGenerated] set; }
			public float increaseRate { [CompilerGenerated] get; [CompilerGenerated] set; }
			public int slipDamageGroup { [CompilerGenerated] get; [CompilerGenerated] set; }
			public CharacterBase from { [CompilerGenerated] get; [CompilerGenerated] set; }
			public ActionTargetGroup hitTargetGroup { [CompilerGenerated] get; [CompilerGenerated] set; }
			public int uniqueIconType { [CompilerGenerated] get; [CompilerGenerated] set; }
			public bool isBuff { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
			// Constructors
			public Regeneration();
	
			// Methods
			public void Reset();
			public void OnReturnEnemyToPool(EnemyCharacter enemy);
			public void SetIsBuffState(CharacterBuffType buffType);
		}
	
		public class GrantData
		{
			// Fields
			[CompilerGenerated]
			private int _multiPlayKey_k__BackingField;
			[CompilerGenerated]
			private float _duration_k__BackingField;
			[CompilerGenerated]
			private int _conditionId_k__BackingField;
			[CompilerGenerated]
			private int _attribute_k__BackingField;
			[CompilerGenerated]
			private int _abilityId_k__BackingField;
	
			// Properties
			public int multiPlayKey { [CompilerGenerated] get; [CompilerGenerated] set; }
			public float duration { [CompilerGenerated] get; [CompilerGenerated] set; }
			public int conditionId { [CompilerGenerated] get; [CompilerGenerated] set; }
			public int attribute { [CompilerGenerated] get; [CompilerGenerated] set; }
			public int abilityId { [CompilerGenerated] get; [CompilerGenerated] set; }
	
			// Constructors
			public GrantData();
		}
	
		public class ValidEffectChecker
		{
			// Fields
			public bool buff;
			public bool debuff;
			public bool shield;
			public bool sparking;
			public List<int> auraIds;
	
			// Constructors
			public ValidEffectChecker();
	
			// Methods
			public void Clear();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0
		{
			// Fields
			public AbilityDataElement ade;
			public CharacterBase owner;
	
			// Constructors
			public __c__DisplayClass8_0();
	
			// Methods
			internal bool _ModifyBuffDebuffDurationPercentage_b__0(BuffUnion buff);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0
		{
			// Fields
			public AbilityDataElement ade;
			public CharacterBase owner;
	
			// Constructors
			public __c__DisplayClass9_0();
	
			// Methods
			internal bool _ModifyBuffDebuffDurationPercentage_b__0(BuffUnion buff);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<CharacterBuffType, bool> __9__16_0;
			public static Func<BuffUnion, bool> __9__297_0;
			public static Func<BuffUnion, bool> __9__299_0;
			public static Func<BuffUnion, bool> __9__300_0;
			public static Func<BuffUnion, bool> __9__301_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _get_typeListForPopulation_b__16_0(CharacterBuffType x);
			internal bool _GetSpecificBuffCount_b__297_0(BuffUnion buff);
			internal bool _HasAnyBuff_b__299_0(BuffUnion buff);
			internal bool _HasAnyDebuff_b__300_0(BuffUnion buff);
			internal bool _HasAnyBuffOrDebuff_b__301_0(BuffUnion buff);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass144_0
		{
			// Fields
			public ActionGrantElement elem;
	
			// Constructors
			public __c__DisplayClass144_0();
	
			// Methods
			internal bool _ResetGrantSkill_b__0(GrantData i);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass183_0
		{
			// Fields
			public CharacterBase owner;
			public CharacterBuffType type;
			public int enhancedId;
			public int skillId;
			public int conditionId;
			public float rate;
			public int modifyChargeLevel;
	
			// Constructors
			public __c__DisplayClass183_0();
	
			// Methods
			internal bool _ApplyEnhancedAction_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass204_0
		{
			// Fields
			public ActionGrantElement elem;
			public int abilityId;
	
			// Constructors
			public __c__DisplayClass204_0();
	
			// Methods
			internal bool _Grant_b__0(GrantData i);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass206_0
		{
			// Fields
			public ActionGrantElement elem;
	
			// Constructors
			public __c__DisplayClass206_0();
	
			// Methods
			internal bool _RemoveGrant_b__0(GrantData i);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass253_0
		{
			// Fields
			public int skillIndex;
	
			// Constructors
			public __c__DisplayClass253_0();
	
			// Methods
			internal bool _RecoverySpForAutoRegene_b__0(BuffUnion buff);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass345_0
		{
			// Fields
			public CharacterBuffType[] excludeTypes;
			public CharacterBuffDispel.PriorityData targetPriority;
			public BuffUnion targetBuff;
	
			// Constructors
			public __c__DisplayClass345_0();
	
			// Methods
			internal bool _FindDispelTarget_b__0(BuffUnion buff);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass346_0
		{
			// Fields
			public int value;
			public CharacterBuff __4__this;
	
			// Constructors
			public __c__DisplayClass346_0();
	
			// Methods
			internal bool _RemoveBuffDebuffByRecoveryHp_b__0(BuffUnion buff);
		}
	
		// Constructors
		public CharacterBuff();
		static CharacterBuff();
	
		// Methods
		public bool VisitAllBuffs(Func<BuffUnion, bool> callback);
		public void Reset(CharacterBase owner, ref BuffUnion buff, RemoveBuffReason reason, bool isNotify);
		public static bool IsBuff(ref BuffUnion buff);
		public static float GetDurationSec(ref BuffUnion buff);
		public static void AddDurationPercentage(ref BuffUnion buff, float addPercentage, bool restrictBetweenZeroAndLifeTime = true);
		public static void AddDurationSec(ref BuffUnion buff, float addVal, bool restrictBetweenZeroAndLifeTime = true);
		public void ModifyBuffDebuffDurationPercentage(CharacterBase owner, AbilityDataElement ade, int actionConditionId, float addPercentage);
		public void ModifyBuffDebuffDurationPercentage(CharacterBase owner, AbilityDataElement ade, CharacterBuffType type, float addPercentage);
		public static int GetDurationNum(ref BuffUnion buff);
		public bool RestoreDataIfNeed(int actionConditionId, int abilityId, ref int durationNum, CharacterBuffType type = CharacterBuffType.None);
		private float GetDeltaTime(CharacterBase owner);
		public void Initialize();
		public void SetMultiPlayService(BuffMultiPlayService multiPlayService);
		public void ReadSyncData(CharacterBase owner, ChangeBuff data);
		public void ResetAll(CharacterBase owner, RemoveBuffReason reason, bool fromSkill, CharacterBuffType[] excludeTypes = null);
		private bool Reset(CharacterBase owner, CharacterBuffType type, ActionConditionElement ace, RemoveBuffReason reason);
		private void ResetRegeneration(CharacterBase owner, RemoveBuffReason reason);
		private void ResetSpecificRegenerationFromUnifiedBuff(CharacterBase owner, CharacterBuffType bufftype, int productId, int conditionId, RemoveBuffReason reason);
		public bool ResetDebuffAll(CharacterBase owner, RemoveBuffReason reason, CharacterBuffType[] excludeTypes = null, int targetDebuffCategory = 0);
		public void ResetBuffAll(CharacterBase owner, RemoveBuffReason reason);
		public bool ResetDebuff(CharacterBase owner, CharacterBuffType type, RemoveBuffReason reason);
		public bool ResetBuff(CharacterBase owner, CharacterBuffType type, RemoveBuffReason reason);
		public bool ProcessScaledBuffOnRemoveForReason(CharacterBuffType type, Parameter buffDebuff, RemoveBuffReason reason);
		private bool ResetBuffDebuff(CharacterBase owner, CharacterBuffType type, bool isBuff, RemoveBuffReason reason, int targetDebuffCategory = 0);
		public void ResetBuffDebuff(CharacterBase owner, int skillId, RemoveBuffReason reason);
		public bool ResetSpecificBuffDebuff(CharacterBase owner, Parameter buffDebuff, RemoveBuffReason reason);
		public int ResetBuffDebuffByConditionId(CharacterBase owner, int conditionId, int abilityId, int productId, RemoveBuffReason reason, bool ignoreAbilityId = false, bool ignoreProductId = false, int toRemoveNum = 0);
		private void RemoveUnifiedBuff(CharacterBase owner, int conditionId, int productId, int abilityId, RemoveBuffReason reason);
		private void ResetUnifiedBuff(CharacterBase owner, UnifiedParameter unifiedBuff, int buffCount, RemoveBuffReason reason, bool isNotify = true);
		public void ResetOnDragonShift(CharacterBase owner);
		public void RemoveForSpecificAction(CharacterBase owner, RemoveAction action);
		private bool IsMatchRemoveAction(RemoveAction action, ActionConditionElement ace);
		private void ResetDamageShield(CharacterBase owner, CharacterBuffType type, RemoveBuffReason reason = RemoveBuffReason.Other);
		public void ResetAllDamageShield(CharacterBase owner, RemoveBuffReason reason = RemoveBuffReason.Other);
		public void RemoveTransBuff(CharacterBase owner, CharacterSkillData csd, RemoveBuffReason reason);
		private void ResetTransSkill(CharacterBase owner, CharacterBuffType type, int skillId);
		private void ResetGrantSkill(CharacterBase owner, CharacterBuffType type, int grantId);
		private void ResetComboShift(CharacterBase owner, CharacterBuffType type);
		private bool RemoveStackBuff(CharacterBase owner, CharacterBuffType type, ActionConditionElement ace, RemoveBuffReason reason);
		private void ResetModeChangeStack(CharacterBase owner, CharacterBuffType type, int conditionId);
		private void ResetInvincible(CharacterBase owner, CharacterBuffType type, int conditionId);
		private void ResetEnhancedBuff(CharacterBase owner, CharacterBuffType type, int conditionId);
		private void ResetEnhancedUnifiedBuff(CharacterBase owner, UnifiedParameter unifiedBuff, int conditionId);
		private void ResetEnhancedUnifiedBuff(CharacterBase owner, UnifiedParameter unifiedBuff, CharacterBuffType type, int conditionId);
		private void ResetIronWall(CharacterBase owner, CharacterBuffType type);
		public int GetDurationNum(CharacterBuffType type);
		public int GetMaxDurationNum(CharacterBuffType type);
		public void ReduceDurationNum(CharacterBase owner, CharacterBuffType type, int ignoreProductId = 0);
		public void ReduceDurationNumDamageShield(CharacterBase owner, CharacterBuffType damageShieldType);
		public void ReduceDurationNumDamageCut(CharacterBase owner, ElementalType attackElement);
		public void ReduceDurationNumSkillDamageUp(CharacterBase owner);
		public bool Update(CharacterBase owner);
		private void ApplyAutoLevelDownOnExpired(CharacterBase owner, int conditionId);
		private bool UpdateDurationTime(CharacterBase owner, CharacterBuffType type, Parameter param);
		private bool UpdateUnifiedBuff(CharacterBase owner);
		private void UpdateRegeneration(CharacterBase owner);
		private void UpdateGrant(CharacterBase owner);
		private void UpdateGrant(CharacterBase owner, AbilityTargetAction targetAction, List<GrantData> list);
		public bool Apply(CharacterBase owner, CollisionHitAttribute attr, int conditionId, CharacterBase applyFrom = null, bool isRestoreBuff = false);
		public bool ApplyByAbility(CharacterBase owner, CharacterBase from, int conditionId, int actionId, int abilityId, bool isLink, Dictionary<int, float> mixedBuffDict = null, int ownerId = 0, int count = 0, bool isRestoreBuff = false, ActionTargetGroup abilityTargetGroup = ActionTargetGroup.MYSELF);
		private int ConvertLeveledActionConditionId(int conditionId, out ActionConditionElement toRemoveAce);
		private bool ApplyCommon(CharacterBase owner, CharacterBase from, int conditionId, int actionId, int skillId, int productId, int abilityId, bool isShowEffect, bool isLink, Dictionary<int, float> mixedBuffDict = null, int ownerId = 0, int count = 0, bool isRestoreBuff = false, bool isFromAbility = false, ActionTargetGroup abilityTargetGroup = ActionTargetGroup.MYSELF, bool isFromQuestSkill = false, bool isBuffDebuffFieldHit = false);
		private int GetMaxBuffDebuffsMaxCount(ActionConditionElement ace);
		private bool IsBuffDebuffMaxCountReached(ActionConditionElement ace, List<Parameter> buffDebuffs);
		private bool IsBuffDebuffMaxCountReached(ActionConditionElement ace, List<UnifiedParameter> unifiedBuffDebuffs);
		private bool IsRegenerationMaxCountReached(ActionConditionElement ace, List<Regeneration> regenerations);
		private bool CanOverwriteAdditionalAttackBuff(CharacterBuffType type, Parameter existingParam, float newDurationSec, ActionConditionElement existingAce, ActionConditionElement newAce, CharacterBase owner, CharacterBase from);
		private bool Apply(CharacterBase owner, CharacterBase from, int type, int actionId, int skillId, int productId, ActionConditionElement ace, int abilityId, bool isShowEffect, bool isLink, float overrideValue = 0f, int ownerId = 0, int count = 0, bool isRestoreBuff = false, bool isFromAbility = false, ActionTargetGroup abilityTargetGroup = ActionTargetGroup.MYSELF, bool isFromQuestSkill = false, bool isBuffDebuffFieldHit = false);
		private bool ApplyUnified(CharacterBase owner, CharacterBase from, int actionId, int skillId, int productId, ActionConditionElement ace, int abilityId, bool isShowEffect, bool isLink, bool isRestoreBuff = false, bool isFromAbility = false, ActionTargetGroup abilityTargetGroup = ActionTargetGroup.MYSELF, bool isBuffDebuffFieldHit = false);
		public bool UnifiedCanOverwriteByGroupId(ActionConditionElement ace, CharacterBase owner, CharacterBase from, int skillId, int actionId, ref UnifiedParameter buffDebuff, ref bool hasSameGroupBuffDebuff);
		public bool HaveSameKeys<T1, T2>(Dictionary<T1, T2> dicA, Dictionary<T1, T2> dicB);
		public bool HasAnyRateGreater(Dictionary<CharacterBuffType, float> dicA, Dictionary<CharacterBuffType, float> dicB);
		public bool RateDicEquals(Dictionary<CharacterBuffType, float> dicA, Dictionary<CharacterBuffType, float> dicB);
		private void ApplyTrans(CharacterBase owner, CharacterBuffType type, int skillId);
		private void ApplyGrant(CharacterBase owner, CharacterBuffType type, int grantId, int abilityId);
		private void ApplyEnhancedAction(CharacterBase owner, CharacterBuffType type, int enhancedId, int skillId, int conditionId, float rate, int modifyChargeLevel);
		private void ApplyDamageShield(CharacterBase owner, CharacterBase from, CharacterBuffType type, ActionConditionElement ace);
		private float ApplySacrificeShieldDamageShield(CharacterBase owner, CharacterBase from, CharacterBuffType type, ActionConditionElement ace, bool isFromMulti = false, float sacrificeShieldHpFromMulti = 0f);
		private void CalculateSacrificeShieldMaxHp(CharacterBase from, ActionConditionElement ace);
		private void CalculateSacrificeShieldConsumeHp(CharacterBase from, ActionConditionElement ace, bool isFromMulti, float sacrificeShieldConsumeHpFromMulti, ref float resultHp);
		private void ApplyTension(CharacterBuffType type);
		private void ApplyInspiration(CharacterBuffType type);
		private void ApplyModeChangeStack(CharacterBase owner, CharacterBuffType type, int stackNum);
		private void ApplyInvincible(CharacterBase owner, CharacterBuffType type, int invincibleLv, int conditionId);
		private void AdditionAttackBuff(CharacterBase owner, CharacterBase from, Parameter buffDebuff, CharacterBuffType buffType, ActionConditionElement ace);
		private void ApplyHiding(CharacterBase owner, CharacterBuffType type);
		private void ApplyCurseOfEmptiness(CharacterBase owner, CharacterBuffType type);
		private void ApplyIronWall(CharacterBase owner, CharacterBuffType type);
		private void ResetHiding(CharacterBase owner, CharacterBuffType type);
		public bool HasHiding();
		private float GetTargetSkillSpUpDebuffRate(CharacterBase owner, CharacterBuffType buffType, int skillId, int actionId, float rate);
		private void ApplyAbility(CharacterBase owner, CharacterBase from, CharacterBuffType type, int actionId, int skillId, float rate, bool isLink);
		private void ApplyAbilityForConsumeBuff(CharacterBase owner, int conditionId);
		private void CheckAbilityForPDLink(CharacterBase owner, CharacterBase from, int actionId, int skillId);
		private void CheckAbilityForChangeBuffTypeCount(CharacterBase owner, int count1, int count2);
		public void Grant(CharacterBase owner, int grantId, int abilityId);
		private void Grant(CharacterBase owner, List<GrantData> list, ActionGrantElement elem, int abilityId);
		public void RemoveGrantAbility(CharacterBase owner, int grantId, int abilityId, RemoveBuffReason reason);
		private void RemoveGrant(CharacterBase owner, AbilityTargetAction targetAction, List<GrantData> list, ActionGrantElement elem, RemoveBuffReason reason);
		private float GetRateBuffDebuff(CharacterBuffType type, bool excludeConditionally = false);
		public float GetRate(CharacterBuffType type, bool excludeConditionally = false, bool withoutLimit = false, int slipHpGroupId = -1);
		private BuffType ConvertCharacterBuffTypeToMasterBuffType(CharacterBuffType type);
		public int GetPercentBuffDebuff(CharacterBuffType type, bool isBuff, out int rawValue, bool excludeConditionally = false);
		public int GetUniqueBuffPercent(InGameBuffUI.UniqueBuffIconType icon, bool isBuff, bool excludeConditionally = false);
		public int GetBuffDebuffLevel(CharacterBuffType type, bool isBuff);
		private bool GetBuffDebuffLevel(int conditionId, ref int level);
		private bool GetBuffDebuffLevel(ActionConditionElement ace, ref int level);
		public int GetUniqueBuffLevel(InGameBuffUI.UniqueBuffIconType icon, bool isBuff);
		public bool GetUniqueBuffBullets(CharacterBase chara, InGameBuffUI.UniqueBuffIconType uniqueBuffIconTyoe, bool isBuff, ref List<StockBulletObject> stockBulletList);
		private void GetDurationTimeBuffDebuff(CharacterBuffType type, bool isMax, bool isBuff, bool isUniqueBuff, int uniqueBuffConditionId, ref float durationTime, ref float lifeTime, ref int durationTimeScale);
		public void GetDurationTimeBuffDebuff(CharacterBuffType type, bool isMax, bool isBuff, out float durationTime, out float lifeTime, out int durationTimeScale);
		public void GetDurationTimeUniqueBuff(InGameBuffUI.UniqueBuffIconType icon, bool isMax, out float durationTime, out float lifeTime, out int durationTimeScale);
		public void GetDurationTime(Parameter param, out float durationTime, out float lifeTime, out int durationTimeScale);
		public int GetBuffDurationNum(CharacterBuffType type, int overWriteGroupId = -1);
		private float GetExtention(CharacterBase from, CharacterBuffType buffType, int actionId, bool isBuff, ActionConditionElement ace);
		private bool IsExtentionDebuff(CharacterBuffType buffType);
		public float GetHpConsumptionCoef();
		public bool IsMaxTension();
		public bool IsMaxTensionOnSkillStart(ActionStartParameter startParameter);
		public bool IsAffectedByTension(CharacterBase owner, int skillId, ActionStartParameter startParameter);
		public int GetTensionLevel();
		public bool IsMaxInspiration();
		public bool IsMaxInspirationOnSkillStart(ActionStartParameter startParameter);
		public int GetInspirationLevel();
		public int GetMalaiseLevel(int rate);
		public int GetMalaiseDamageLimit();
		public bool CheckNonUniqueIconBuffForBuffDebuffDic(CharacterBuffType type);
		public void SetSkillDamageUpOnSkillStart();
		public bool HasBuffDebuffCountByConditionId(int conditionId, int abilityId, int productId);
		public int GetBuffCount();
		public int GetDebuffCount();
		public int GetBuffDebuffCount(CharacterBuffType type, bool isBuff, bool forIcon = false, bool includeUniqueIcon = false);
		public int GetUniqueBuffCount(CharacterBase curChara, InGameBuffUI.UniqueBuffIconType icon);
		public int GetBuffCountForConditionId(int conditionId);
		public int GetBuffTypeCount();
		public void GetUniqueBuffIconList(ref List<int> list);
		public bool IsActivateSkill(CharacterBase owner, int id);
		public void Regenerate(CharacterBase owner, Dictionary<CharacterBase, int> froms, CharacterBuffType buffType, int uniqueBuffIcon, int heal1, int heal2, int heal3, int heal4, int damage1, bool isFollower, bool withSE = true, float dragonTimerDamage = 0f);
		private int GetRecoverySpSlot(CharacterBase owner, int abilityId, int defaultSlot);
		public void ApplyDebuffExtraDamage(int damage, CharacterBase owner, CharacterBase from, int actionConditionId);
		public static void DispBuffCaption(CharacterBase owner, int actionConditionId);
		private void ApplySlipDamage(int damage, bool isFollower, CharacterBase owner, Dictionary<CharacterBase, int> froms, CharacterBuffType buffType, int uniqueBuffIcon);
		private bool ApplyDragonTimerSlipDamage(int damage, bool isFollower, CharacterBase owner, CharacterBuffType buffType, int uniqueBuffIcon, float dragonTimerDamage = 0f);
		private void RecoverySpForAutoRegene(CharacterBase owner, int healValue, int skillIndex, bool withSE);
		public static float GetTransitionRate(CharacterBuffType type, ActionConditionElement ace, out int enhancedId);
		private static bool IsPauseOnDeathBuffDebuff(CharacterBase owner, CharacterBuffType type);
		private static bool IsPauseEnhancedBuff(CharacterBase owner, CharacterBuffType type, int conditionId);
		private float RecoveryHpCoef(CharacterBase from, int actionId);
		private bool SetupRegeneration(CharacterBase owner, CharacterBase from, ActionConditionElement ace, int actionId, int abilityId, int skillId, int productId, float durationSec, ActionTargetGroup hitTargetGroup, int requiredRecoverHp, float rateIncreaseByTime, float rateIncreaseDuration, bool fromUnifiedBuff, bool isUnifiedOverwrite = false);
		private bool RegeneCanOverwriteByGroupId(ActionConditionElement ace, RegenerationType regeneType, Regeneration originRegene, Regeneration overwriteRegene, CharacterBase owner, int abilityId, float coef);
		private void PlayBuffEffectOneShot(CharacterBase owner, ActionConditionElement ace);
		private void PlayDebuffEffectOneShot(CharacterBase owner, ActionConditionElement ace);
		private void PlayStartEffect(CharacterBase owner, ActionConditionElement ace, string defaultEffect);
		private void PlayBuffEffect(CharacterBase owner);
		private void PlayDebuffEffect(CharacterBase owner);
		private void PlayDamageShieldEffect(CharacterBase owner);
		private void PlayGuardEffect(CharacterBase owner);
		public void PlayAuraEffect(CharacterBase owner, int id);
		private void PlayAuraEffect(CharacterBase owner, AuraEffectElement aee);
		private void PlayAuraEffect_Default(CharacterBase owner, AuraEffectElement aee, int trigger = 0);
		private void PlayAuraEffect_Element(CharacterBase owner, AuraEffectElement aee);
		private void PlayAuraEffect_IsDragon(CharacterBase owner, AuraEffectElement aee);
		private void PlayAuraEffect_IsLoop(CharacterBase owner, AuraEffectElement aee);
		private void PlayAuraEffect_IsDependOnCp(CharacterBase owner, AuraEffectElement aee);
		public void PlayPowerUpComboEffect(CharacterBase owner, int trg = -1);
		private void PlaySparkingEffect(CharacterBase owner);
		private void PlayDispelProduction(CharacterBase owner);
		private void PlayEffect(CharacterBase owner, string key, string effectName, EffectObject.EraseType eraseType = EffectObject.EraseType.DELETE, int trigger = 0, int auraGroup = 0, bool isDynamicScale = false, string bindPos = null);
		private void KickTrigger(CharacterBase owner, string key, int trigger);
		private static void DispText(CharacterBase owner, int type, float rate, string text, BuffCaption.Param.IconType iconType, CharacterBuffType buffType);
		private string GetText(CharacterBuffType type, ActionConditionElement ace);
		public void RestoreEffect(CharacterBase owner);
		public void StopEffect(CharacterBase owner);
		public void StopPowerUpComboEffect(CharacterBase owner, bool isForce);
		public void StopBuffDebuffEffect(CharacterBase owner);
		public void ForceStopEffect(CharacterBase owner);
		private void IsValid(CharacterBase owner);
		private void CheckValid(AuraID auraId, CharacterBuffType buffType, float rate, Parameter.InternalFlagType internalFlag);
		private bool IsConditionally(ActionConditionElement ace);
		public bool IsConditionallyElements(CharacterBase owner, ActionConditionElement ace);
		public bool HasConditionId(int conditionId);
		public bool HasDebuff(CharacterBuffType type);
		public bool HasDebuff(ActionDefDebuff typeId, int slipHpGroupId = -1);
		public int GetSpecificBuffCount(int actionConditionId);
		public int GetDuplicatedBuffCount(int specificId = 0);
		public bool HasAnyBuff();
		public bool HasAnyDebuff();
		public bool HasAnyBuffOrDebuff();
		public bool HasEnhancedSkillBuff(int idx);
		public bool HasDamageCut2();
		public bool HasDamageShield(CharacterBuffType damageShieldType);
		public bool HasHealInvalid();
		public bool HasTensionUpInvalid();
		public float CaclulateSkillRecovery(CharacterBase owner, int skillIdx, float value, float originValue, float rate);
		public bool HasSelfDamage();
		public bool HasHpConsumption();
		public bool HasDisableAction();
		public bool HasDisableMove();
		public bool HasComboShift();
		public bool HasGoldenBarrier();
		public bool HasIronWall();
		public bool HasDisableActionFlag(InGameDef.ActionFlag flag);
		public void ExecDamageLink(CharacterBase owner);
		public void ExecAdditionAttack(CharacterBase owner, CollisionHitAttribute hitAttribute);
		public void ConditionallyList(CharacterBuffType type, out List<int> list);
		public void RemoveZombieBuff(CharacterBase owner);
		private bool GetRateMinMax(CharacterBuffType type, out float min, out float max);
		private int CreateMultiPlayKey(CharacterBase owner);
		private List<GrantData> GetGrantDataList(AbilityTargetAction targetAction);
		private bool IsDuplicatableBuffType(CharacterBuffType type);
		private static bool IsDuplicatableAlways(ActionConditionElement ace);
		private static bool IsOverwritableAlways(ActionConditionElement ace);
		private bool IsRegene(CharacterBuffType type);
		private bool IsRegeneDebuff(CharacterBuffType type);
		private bool IsDamageShield(CharacterBuffType type);
		private bool IsSacrificeShield(CharacterBuffType type);
		public bool IsShieldSeries(CharacterBuffType type);
		private void PostApplyParameterBuff(CharacterBase owner, CharacterBase from, CharacterBuffType buffType, Parameter buffDebuff, ActionConditionElement ace, int actionId, bool isShowEffect, bool isSyncData);
		public void SetHitData(ActionConditionElement elem, CharacterBase from, int actionId, int skillId, int productId, int type, bool isUnifiedBuff);
		public bool CheckHitData(ActionConditionElement elem, CharacterBase from, int actionId, int skillId, int productId, int type, bool isUnifiedBuff, bool isBuffDebuffFieldHit);
		public void RemoveHitData(CollisionHitAttribute attr);
		private void ReadParameterSyncData(CharacterBase owner, List<ParameterSyncData> addParameters, List<RemoveSyncData> removeParameters);
		private void ReadRegenerationSyncData(CharacterBase owner, List<RegenerationSyncData> addRegeneration, List<RemoveSyncData> removeRegeneration);
		private void ReadGrantSyncData(CharacterBase owner, List<GrantSyncData> addGrants, List<RemoveSyncData> removeGrants);
		private void ReadAddGrantSyncData(CharacterBase owner, AbilityTargetAction targetAction, List<GrantData> list, GrantSyncData grant);
		private bool ReadRemoveGrantSyncData(CharacterBase owner, AbilityTargetAction targetAction, List<GrantData> list, RemoveSyncData removeData);
		private void ReadUnifiedParameterSyncData(CharacterBase owner, List<UnifiedParameterSyncData> addUnifiedParameters, List<RemoveSyncData> removeUnifiedParameters);
		private void RecoveryHpBuff(CharacterBase owner, float rate, int actionId, bool needSync);
		public void RecoveryHpConditionallyAbility(CharacterBase owner, int hp, bool needSync);
		private void Dispel(CharacterBase owner, CharacterBase from, ActionConditionElement ace, int actionId, int skillId, int productId, CharacterBuffType[] excludeTypes = null);
		private void CheckDispelProductionForReceiver(CharacterBase owner, CharacterBase from, int conditionId, int actionId, int skillId, int productId, CharacterBuffType[] excludeTypes = null);
		private BuffUnion FindDispelTarget(CharacterBase owner, CharacterBuffType[] excludeTypes = null);
		public void RemoveBuffDebuffByRecoveryHp(CharacterBase owner, int value);
		public void SetSacrificeShieldHp(CharacterBase owner, float hp, int followerAvoid = -1);
		public void ReduceSacrificeShieldHp(CharacterBase owner, float hp, bool needSync, int followerAvoid = -1);
		private void SendReduceSacrificeShieldHp(float hp, CharacterBase owner);
		public void ReciveReduceSacrificeShieldHp(float hp, CharacterBase owner);
		private bool IsNoSyncBuff(int conditionId);
		private bool CanRemoveCategoryDebuff(int targetDebuffCategory, ActionConditionElement ace, RemoveBuffReason reason);
		public void OnReturnEnemyToPool(EnemyCharacter enemy);
		[CompilerGenerated]
		private bool _GetDuplicatedBuffCount_b__298_0(BuffUnion buff);
	}
}
