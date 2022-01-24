using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.Bullet;
using Gluon.Event;
using Gluon.Master;

namespace Gluon
{
	public class CharacterBuff
	{
		public static class EfficacyType
		{
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
			public enum BuffCategories
			{
				None,
				NormalParameter,
				UnifiedParameter,
				Regeneration,
				Grant
			}

			public BuffCategories category;

			public CharacterBuffType type;

			public AbilityTargetAction targetAction;

			public Parameter paramBuff;

			public UnifiedParameter unifiedBuff;

			public Regeneration regene;

			public GrantData grant;

			public int ActionConditionId => default(int);

			public int AbilityId => default(int);

			public Parameter.InternalFlagType InternalFlag => default(Parameter.InternalFlagType);

			public static BuffUnion None()
			{
				return default(BuffUnion);
			}

			public void Clear()
			{
			}

			public static BuffUnion FromNormalParameterBuff(CharacterBuffType type, Parameter buff)
			{
				return default(BuffUnion);
			}

			public static BuffUnion FromUnifiedParameterBuff(UnifiedParameter buff)
			{
				return default(BuffUnion);
			}

			public static BuffUnion FromRegeneration(CharacterBuffType type, Regeneration buff)
			{
				return default(BuffUnion);
			}

			public static BuffUnion FromGrant(AbilityTargetAction targetAction, GrantData buff)
			{
				return default(BuffUnion);
			}
		}

		private class TypeComparer : IEqualityComparer<CharacterBuffType>
		{
			public bool Equals(CharacterBuffType x, CharacterBuffType y)
			{
				return default(bool);
			}

			public int GetHashCode(CharacterBuffType obj)
			{
				return default(int);
			}
		}

		private enum RegenerationType
		{
			Hp,
			Sp,
			Dp,
			SlipHp,
			AutoS2,
			AutoS1,
			AutoSW
		}

		public enum ActionDefDebuff
		{
			None,
			Hp,
			Attack,
			Defense,
			Critical,
			SkillDamage,
			BurstDamage,
			Recovery,
			Regeneration,
			ElementalResist,
			EnhancedBurst,
			EnhancedSkill,
			AttackSpeed,
			EnhancedAttack,
			Hp_Attack,
			CriticalDamage,
			SlipHp,
			Nicked,
			Malaise,
			SPDamage,
			DisableAction,
			AttackOrDefense,
			HLExclusive
		}

		private enum AuraID
		{
			None,
			Common
		}

		public enum ElementalBitShift
		{
			None = 0,
			Fire = 1,
			Water = 2,
			Wind = 4,
			Light = 8,
			Dark = 0x10
		}

		[Flags]
		public enum SkillIndexBitShift
		{
			None = 0x0,
			Skill_1 = 0x1,
			Skill_2 = 0x2,
			Skill_3 = 0x4,
			Skill_4 = 0x8
		}

		public enum RemoveAction
		{
			None,
			DragonShift,
			WeaponSkill,
			SupportSkill,
			ShareSkill
		}

		private enum BlockExhaustFlag
		{
			None = 0,
			InAnySkill = 1,
			InTransform = 2,
			AnyReset = 4
		}

		[Flags]
		public enum GrantAttribute
		{
			None = 0x0,
			DragonAttack = 0x1
		}

		public enum BuffOverwriteTypes
		{
			Duplicate,
			Overwrite,
			NoEffect,
			VesselBomb
		}

		public class Parameter
		{
			public enum DurationType
			{
				None,
				Time,
				Num,
				Both,
				UntilDead
			}

			[Flags]
			public enum InternalFlagType
			{
				Normal = 0x0,
				NoIcon = 0x1,
				NoCount = 0x2,
				PenetrateDragon = 0x4,
				UnableTransform = 0x8
			}

			public CharacterBase from
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

			public CharacterBuffType buffType
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

			public int actionId
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int skillId
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int productId
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int ownerId
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int count
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int grantId
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public float rate
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public float durationSec
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int durationTimeScale
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public float lifeSec
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int durationNum
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int maxDurationNum
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public float coolDownTimeSec
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public InternalFlagType internalFlag
			{
				[CompilerGenerated]
				get
				{
					return default(InternalFlagType);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public DurationType durationType
			{
				[CompilerGenerated]
				get
				{
					return default(DurationType);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public int multiPlayKey
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int conditionId
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int abilityId
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public AbilityConst.UnitType unitType
			{
				[CompilerGenerated]
				get
				{
					return default(AbilityConst.UnitType);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public ActionTargetGroup hitTargetGroup
			{
				[CompilerGenerated]
				get
				{
					return default(ActionTargetGroup);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public string linkHitAttr
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public string additionAttackHitAttr
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public bool curseOfEmptinessInvalid
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

			public int requiredRecoverHpToDeleteThisBuff
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int requiredRecoverHpCount
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public bool isSpecifyBuffIconId
			{
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public int buffIconId
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public string iconName
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

			public InGameBuffUI.ValueDisplayType valueDispType
			{
				[CompilerGenerated]
				get
				{
					return default(InGameBuffUI.ValueDisplayType);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public InGameBuffUI.GaugeDisplayType gaugeDispType
			{
				[CompilerGenerated]
				get
				{
					return default(InGameBuffUI.GaugeDisplayType);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public virtual bool isBuff => default(bool);

			public virtual void Reset(CharacterBase owner)
			{
			}

			public void Set(CharacterBase from, CharacterBuffType buffType, int actionId, int skillId, int productId, int ownerId, int count, int enhancedId, float rate, float durationSec, int durationNum, int maxDurationNum, int durationTimeScale, float coolDownTimeSec, int conditionId, int abilityId, ActionTargetGroup hitTargetGroup, int curseOfEmptinessInvalid, int requiredRecoverHp, AbilityConst.UnitType unitType)
			{
			}

			public void ApplyIconData()
			{
			}
		}

		public class UnifiedParameter : Parameter
		{
			public Dictionary<CharacterBuffType, float> rateDic;

			private bool? _isBuff;

			public override bool isBuff => default(bool);

			public override void Reset(CharacterBase owner)
			{
			}
		}

		public class Regeneration
		{
			public CharacterBuffType buffType
			{
				[CompilerGenerated]
				get
				{
					return default(CharacterBuffType);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public float duration
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public float life
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public float interval
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public float intervalTimer
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public float healValue1
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public float healValue2
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public float healValue3
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public float healValue4
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public float rate
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int multiPlayKey
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int conditionId
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int abilityId
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int actionId
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int skillId
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int productId
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public float rateIncreaseByTime
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public float rateIncreaseByTimeTimer
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public float rateIncreaseDuration
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public float increaseRate
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int slipDamageGroup
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int ownerId
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public AbilityConst.UnitType unitType
			{
				[CompilerGenerated]
				get
				{
					return default(AbilityConst.UnitType);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public CharacterBase from
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public ActionTargetGroup hitTargetGroup
			{
				[CompilerGenerated]
				get
				{
					return default(ActionTargetGroup);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public bool isSpecifyBuffIconId
			{
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public int buffIconId
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public string iconName
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

			public InGameBuffUI.ValueDisplayType valueDispType
			{
				[CompilerGenerated]
				get
				{
					return default(InGameBuffUI.ValueDisplayType);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public InGameBuffUI.GaugeDisplayType gaugeDispType
			{
				[CompilerGenerated]
				get
				{
					return default(InGameBuffUI.GaugeDisplayType);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public bool isBuff
			{
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public bool fromUnifiedBuff
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

			public Parameter.InternalFlagType internalFlag
			{
				[CompilerGenerated]
				get
				{
					return default(Parameter.InternalFlagType);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public void Reset()
			{
			}

			public void OnReturnEnemyToPool(EnemyCharacter enemy)
			{
			}

			public void SetIsBuffState(CharacterBuffType buffType)
			{
			}

			public void ApplyIconData()
			{
			}
		}

		public class GrantData
		{
			public int multiPlayKey
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public float duration
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int conditionId
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int attribute
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public int abilityId
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				set
				{
				}
			}
		}

		public class ValidEffectChecker
		{
			public bool buff;

			public bool debuff;

			public bool shield;

			public bool sparking;

			public List<int> auraIds;

			public void Clear()
			{
			}
		}

		public class RecoveryOpeningDebuffData
		{
			public int conditionId;

			public CharacterBase owner;

			public CharacterBase from;

			public RecoveryOpeningDebuffData(int conditionId, CharacterBase owner, CharacterBase from)
			{
			}
		}

		private static CharacterBuffType[] _typeListForPopulation;

		private static readonly int enumRegenerationTypeCount;

		public static readonly int enumActionDefDebuffCount;

		public static readonly int tensionMaxLevel;

		public static readonly int inspirationMaxLevel;

		public static readonly int malaiseMaxLevel;

		public static readonly int dbfGashDamageGroupId;

		private List<int> unifiedBuffDisplayedList;

		public float sacrificeShieldMaxHp;

		private int tensionLevelBeforeApply;

		private int inspirationLevelBeforeApply;

		private List<BuffUnion> skillDamageUpBuffsOnSkillStart;

		private static readonly CharacterBuffType[] excludeTypes;

		public List<Parameter> notRemoveDebufList;

		public List<int> removedBuffUnionList;

		public List<Parameter> tmpHpRecoverdRemovedBuffDebuffs;

		private List<Regeneration> removeRegeneList;

		public List<int> tmpRegeneGroups;

		public float tmpRegeneDragonTimerDamage;

		public List<int> countedUnifiedConditionIdList;

		private const int defaultBuffDebuffsMaxCount = 20;

		private Dictionary<CharacterBuffType, List<Parameter>> buffDebuffDic;

		private Dictionary<int, List<UnifiedParameter>> unifiedDic;

		private List<int> resetSkillIds;

		private Dictionary<CharacterBuffType, List<Regeneration>> regenerationDic;

		private Dictionary<int, List<GrantData>> _grantListDic;

		private static readonly int hitDataMax;

		public List<CharacterHitData> hitDataList;

		private CharacterHitData[] hitData;

		private ValidEffectChecker validEffect;

		private CollisionHitAttribute _hitAttr;

		private string _hitAttrId;

		private ActionTargetGroup _hitAttrTargetGroup;

		private ActionStartParameter _hitAttrActionStartParam;

		private CharacterBase _lastHitChara;

		private CharacterParameter.FluctuationParameter baseParam;

		private BuffMultiPlayService _multiPlayService;

		private Dictionary<CharacterBase, int> regeneratorDict;

		private List<int> buffIconIdList;

		private static bool hasBuffDebuffCheckResult;

		private static int specificBuffCheckCount;

		private static int specificBuffCheckId;

		private static float specificBuffFloatVal;

		private static int enableCheckSkillId;

		private static bool hasEnableBuffResult;

		public static CharacterBuffType[] typeListForPopulation => null;

		public float[] shieldUserHp
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

		public float sacrificeShieldHp
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float sacrificeShieldConsumeHp
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float skillDamageUpRateOnSkillStart
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public CharacterBuffCoolDownController coolDownController
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

		public Action<CharacterBuffType, Parameter> onBuffDebuffApplied
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float elapsedSupportGameTime
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Dictionary<CharacterBuffType, List<Parameter>> BuffDebuffDic => null;

		public Dictionary<int, List<UnifiedParameter>> UnifiedDic => null;

		public Dictionary<CharacterBuffType, List<Regeneration>> RegenerationDic => null;

		public List<GrantData> comboGrant
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

		public List<GrantData> burstGrant
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

		public List<GrantData> skill1Grant
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

		public List<GrantData> skill2Grant
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

		public List<GrantData> skillAllGrant
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

		public BuffMultiPlayService MultiPlayService => null;

		public CharacterTriggerCtrl BuffTriggerCtrl
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

		public CharacterBuffRestoreCtrl BuffRestoreCtrl
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

		public bool receivedOpeningDebuffEvent
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

		private RecoveryOpeningDebuffData recoveryOpeningDebuff
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool VisitAllBuffs(Func<BuffUnion, bool> callback)
		{
			return default(bool);
		}

		public void Reset(CharacterBase owner, ref BuffUnion buff, RemoveBuffReason reason, bool isNotify)
		{
		}

		public static bool IsBuff(ref BuffUnion buff)
		{
			return default(bool);
		}

		public static float GetDurationSec(ref BuffUnion buff)
		{
			return default(float);
		}

		public static void AddDurationPercentage(CharacterBase owner, ref BuffUnion buff, float addPercentage, bool restrictBetweenZeroAndLifeTime = true)
		{
		}

		public static void AddDurationSec(CharacterBase owner, ref BuffUnion buff, float addVal, bool restrictBetweenZeroAndLifeTime = true)
		{
		}

		public void ModifyBuffDebuffDurationPercentage(CharacterBase owner, AbilityDataElement ade, int actionConditionId, float addPercentage)
		{
		}

		public void ModifyBuffDebuffDurationPercentage(CharacterBase owner, AbilityDataElement ade, CharacterBuffType type, float addPercentage)
		{
		}

		public static int GetDurationNum(ref BuffUnion buff)
		{
			return default(int);
		}

		public bool RestoreDataIfNeed(int actionConditionId, int abilityId, ref int durationNum, CharacterBuffType type = CharacterBuffType.None)
		{
			return default(bool);
		}

		public static float GetDeltaTime(CharacterBase owner)
		{
			return default(float);
		}

		public void Initialize()
		{
		}

		public void SetMultiPlayService(BuffMultiPlayService multiPlayService)
		{
		}

		public void ReadSyncData(CharacterBase owner, ChangeBuff data)
		{
		}

		public bool ResetAll(CharacterBase owner, RemoveBuffReason reason, bool fromSkill, [Optional] CharacterBuffType[] excludeTypes)
		{
			return default(bool);
		}

		private bool Reset(CharacterBase owner, CharacterBuffType type, ActionConditionElement ace, RemoveBuffReason reason)
		{
			return default(bool);
		}

		private bool ResetRegeneration(CharacterBase owner, RemoveBuffReason reason)
		{
			return default(bool);
		}

		private void ResetSpecificRegenerationFromUnifiedBuff(CharacterBase owner, CharacterBuffType bufftype, int productId, int conditionId, RemoveBuffReason reason)
		{
		}

		public bool ResetDebuffAll(CharacterBase owner, RemoveBuffReason reason, [Optional] CharacterBuffType[] excludeTypes, int targetDebuffCategory = 0)
		{
			return default(bool);
		}

		public bool ResetBuffAll(CharacterBase owner, RemoveBuffReason reason)
		{
			return default(bool);
		}

		public bool ResetDebuff(CharacterBase owner, CharacterBuffType type, RemoveBuffReason reason)
		{
			return default(bool);
		}

		public bool ResetBuff(CharacterBase owner, CharacterBuffType type, RemoveBuffReason reason)
		{
			return default(bool);
		}

		public bool ResetBuffDebuffAllFromSpecifiedCharacter(CharacterBase owner, CharacterBase from, bool isBuff, RemoveBuffReason reason)
		{
			return default(bool);
		}

		public bool ProcessScaledBuffOnRemoveForReason(CharacterBuffType type, Parameter buffDebuff, RemoveBuffReason reason)
		{
			return default(bool);
		}

		private bool ResetBuffDebuff(CharacterBase owner, CharacterBuffType type, bool isBuff, RemoveBuffReason reason, int targetDebuffCategory = 0, [Optional] CharacterBase from)
		{
			return default(bool);
		}

		public void ResetBuffDebuff(CharacterBase owner, int skillId, RemoveBuffReason reason)
		{
		}

		public bool ResetSpecificBuffDebuff(CharacterBase owner, Parameter buffDebuff, RemoveBuffReason reason)
		{
			return default(bool);
		}

		public int ResetBuffDebuffByConditionId(CharacterBase owner, int conditionId, int abilityId, int productId, RemoveBuffReason reason, bool ignoreAbilityId = false, bool ignoreProductId = false, int toRemoveNum = 0, bool ignoreConditionId = false)
		{
			return default(int);
		}

		private void RemoveUnifiedBuff(CharacterBase owner, int conditionId, int productId, int abilityId, RemoveBuffReason reason)
		{
		}

		private void ResetUnifiedBuff(CharacterBase owner, UnifiedParameter unifiedBuff, int buffCount, RemoveBuffReason reason, bool isNotify = true)
		{
		}

		public void ResetOnDragonShift(CharacterBase owner)
		{
		}

		public void RemoveForSpecificAction(CharacterBase owner, RemoveAction action)
		{
		}

		private bool IsMatchRemoveAction(RemoveAction action, ActionConditionElement ace)
		{
			return default(bool);
		}

		private void ResetDamageShield(CharacterBase owner, CharacterBuffType type, RemoveBuffReason reason = RemoveBuffReason.Other)
		{
		}

		public void ResetAllDamageShield(CharacterBase owner, RemoveBuffReason reason = RemoveBuffReason.Other)
		{
		}

		public void RemoveTransBuff(CharacterBase owner, CharacterSkillData csd, RemoveBuffReason reason)
		{
		}

		private void ResetTransSkill(CharacterBase owner, CharacterBuffType type, int skillId)
		{
		}

		private void ResetGrantSkill(CharacterBase owner, CharacterBuffType type, int grantId)
		{
		}

		private void ResetComboShift(CharacterBase owner, CharacterBuffType type)
		{
		}

		private bool RemoveStackBuff(CharacterBase owner, CharacterBuffType type, ActionConditionElement ace, RemoveBuffReason reason)
		{
			return default(bool);
		}

		private void ResetModeChangeStack(CharacterBase owner, CharacterBuffType type, int conditionId)
		{
		}

		private void ResetInvincible(CharacterBase owner, CharacterBuffType type, int conditionId)
		{
		}

		private void ResetEnhancedBuff(CharacterBase owner, CharacterBuffType type, int conditionId)
		{
		}

		private void ResetEnhancedUnifiedBuff(CharacterBase owner, UnifiedParameter unifiedBuff, int conditionId)
		{
		}

		private void ResetEnhancedUnifiedBuff(CharacterBase owner, UnifiedParameter unifiedBuff, CharacterBuffType type, int conditionId)
		{
		}

		private void ResetIronWall(CharacterBase owner, CharacterBuffType type)
		{
		}

		public int GetDurationNum(CharacterBuffType type)
		{
			return default(int);
		}

		public int GetDurationNum(int buffIconId, bool isBuff)
		{
			return default(int);
		}

		public int GetMaxDurationNum(CharacterBuffType type)
		{
			return default(int);
		}

		public void ReduceDurationNum(CharacterBase owner, CharacterBuffType type, int ignoreProductId = 0)
		{
		}

		public void ReduceDurationNumDamageShield(CharacterBase owner, CharacterBuffType damageShieldType)
		{
		}

		public void ReduceDurationNumDamageCut(CharacterBase owner, ElementalType attackElement)
		{
		}

		public void ReduceDurationNumSkillDamageUp(CharacterBase owner)
		{
		}

		public bool Update(CharacterBase owner)
		{
			return default(bool);
		}

		private void ApplyAutoLevelDownOnExpired(CharacterBase owner, CharacterBase from, int conditionId)
		{
		}

		private bool WillAutoLevelDownOnExpired(int conditionId)
		{
			return default(bool);
		}

		private bool UpdateDurationTime(CharacterBase owner, CharacterBuffType type, Parameter param)
		{
			return default(bool);
		}

		private bool UpdateUnifiedBuff(CharacterBase owner)
		{
			return default(bool);
		}

		private void UpdateRegeneration(CharacterBase owner)
		{
		}

		private void UpdateGrant(CharacterBase owner)
		{
		}

		private void UpdateGrant(CharacterBase owner, AbilityTargetAction targetAction, List<GrantData> list)
		{
		}

		public bool Apply(CharacterBase owner, CollisionHitAttribute attr, int conditionId, [Optional] CharacterBase applyFrom, bool isRestoreBuff = false)
		{
			return default(bool);
		}

		public bool ApplyByAbility(CharacterBase owner, CharacterBase from, int conditionId, int actionId, int abilityId, bool isLink, [Optional] Dictionary<int, float> mixedBuffDict, int ownerId = 0, int count = 0, bool isRestoreBuff = false, ActionTargetGroup abilityTargetGroup = ActionTargetGroup.MYSELF, AbilityConst.UnitType unitType = AbilityConst.UnitType.None)
		{
			return default(bool);
		}

		private int ConvertLeveledActionConditionId(int conditionId, out ActionConditionElement toRemoveAce)
		{
			return default(int);
		}

		private bool ApplyCommon(CharacterBase owner, CharacterBase from, int conditionId, int actionId, int skillId, int productId, int abilityId, bool isShowEffect, bool isLink, [Optional] Dictionary<int, float> mixedBuffDict, int ownerId = 0, int count = 0, bool isRestoreBuff = false, bool isFromAbility = false, ActionTargetGroup abilityTargetGroup = ActionTargetGroup.MYSELF, bool isFromQuestSkill = false, bool isBuffDebuffFieldHit = false, AbilityConst.UnitType unitType = AbilityConst.UnitType.None, int buffExplosionHitId = 0)
		{
			return default(bool);
		}

		private int GetMaxBuffDebuffsMaxCount(ActionConditionElement ace)
		{
			return default(int);
		}

		private bool IsBuffDebuffMaxCountReached(ActionConditionElement ace, List<Parameter> buffDebuffs)
		{
			return default(bool);
		}

		private bool IsBuffDebuffMaxCountReached(ActionConditionElement ace, List<UnifiedParameter> unifiedBuffDebuffs)
		{
			return default(bool);
		}

		private bool IsRegenerationMaxCountReached(ActionConditionElement ace, List<Regeneration> regenerations)
		{
			return default(bool);
		}

		private bool CanOverwriteAdditionalAttackBuff(CharacterBuffType type, Parameter existingParam, float newDurationSec, ActionConditionElement existingAce, ActionConditionElement newAce, CharacterBase owner, CharacterBase from)
		{
			return default(bool);
		}

		private bool Apply(CharacterBase owner, CharacterBase from, int type, int actionId, int skillId, int productId, ActionConditionElement ace, int abilityId, bool isShowEffect, bool isLink, float overrideValue = 0f, int ownerId = 0, int count = 0, bool isRestoreBuff = false, bool isFromAbility = false, ActionTargetGroup abilityTargetGroup = ActionTargetGroup.MYSELF, bool isFromQuestSkill = false, bool isBuffDebuffFieldHit = false, AbilityConst.UnitType unitType = AbilityConst.UnitType.None)
		{
			return default(bool);
		}

		private bool ApplyUnified(CharacterBase owner, CharacterBase from, int actionId, int skillId, int productId, ActionConditionElement ace, int abilityId, int ownerId, bool isShowEffect, bool isLink, bool isRestoreBuff = false, bool isFromAbility = false, ActionTargetGroup abilityTargetGroup = ActionTargetGroup.MYSELF, bool isBuffDebuffFieldHit = false, AbilityConst.UnitType unitType = AbilityConst.UnitType.None)
		{
			return default(bool);
		}

		public bool UnifiedCanOverwriteByGroupId(ActionConditionElement ace, CharacterBase owner, CharacterBase from, int skillId, int actionId, ref UnifiedParameter buffDebuff, ref bool hasSameGroupBuffDebuff)
		{
			return default(bool);
		}

		public bool HaveSameKeys<T1, T2>(Dictionary<T1, T2> dicA, Dictionary<T1, T2> dicB)
		{
			return default(bool);
		}

		public bool HasAnyRateGreater(Dictionary<CharacterBuffType, float> dicA, Dictionary<CharacterBuffType, float> dicB)
		{
			return default(bool);
		}

		public bool RateDicEquals(Dictionary<CharacterBuffType, float> dicA, Dictionary<CharacterBuffType, float> dicB)
		{
			return default(bool);
		}

		private void ApplyTrans(CharacterBase owner, CharacterBuffType type, int skillId)
		{
		}

		private void ApplyGrant(CharacterBase owner, CharacterBuffType type, int grantId, int abilityId)
		{
		}

		private void ApplyEnhancedAction(CharacterBase owner, CharacterBuffType type, int enhancedId, int skillId, int conditionId, float rate, int modifyChargeLevel)
		{
		}

		private void ApplyDamageShield(CharacterBase owner, CharacterBase from, CharacterBuffType type, ActionConditionElement ace)
		{
		}

		private float ApplySacrificeShieldDamageShield(CharacterBase owner, CharacterBase from, CharacterBuffType type, ActionConditionElement ace, bool isFromMulti = false, float sacrificeShieldHpFromMulti = 0f)
		{
			return default(float);
		}

		private void CalculateSacrificeShieldMaxHp(CharacterBase from, ActionConditionElement ace)
		{
		}

		private void CalculateSacrificeShieldConsumeHp(CharacterBase from, ActionConditionElement ace, bool isFromMulti, float sacrificeShieldConsumeHpFromMulti, ref float resultHp)
		{
		}

		private void ApplyTension(CharacterBuffType type)
		{
		}

		private void ApplyInspiration(CharacterBuffType type)
		{
		}

		private void ApplyModeChangeStack(CharacterBase owner, CharacterBuffType type, int stackNum)
		{
		}

		private void ApplyInvincible(CharacterBase owner, CharacterBuffType type, int invincibleLv, int conditionId)
		{
		}

		private void AdditionAttackBuff(CharacterBase owner, CharacterBase from, Parameter buffDebuff, CharacterBuffType buffType, ActionConditionElement ace)
		{
		}

		private void ApplyHiding(CharacterBase owner, CharacterBuffType type)
		{
		}

		private void ApplyCurseOfEmptiness(CharacterBase owner, CharacterBuffType type)
		{
		}

		private void ApplyIronWall(CharacterBase owner, CharacterBuffType type)
		{
		}

		private void ResetHiding(CharacterBase owner, CharacterBuffType type)
		{
		}

		public bool HasHiding()
		{
			return default(bool);
		}

		private float GetTargetSkillSpUpDebuffRate(CharacterBase owner, CharacterBuffType buffType, int skillId, int actionId, float rate)
		{
			return default(float);
		}

		public void RemoveAbility(CharacterBase owner, AbilityConst.UnitType unitType, int ownerId)
		{
		}

		private void ApplyAbility(CharacterBase owner, CharacterBase from, CharacterBuffType type, int actionId, int skillId, float rate, bool isLink)
		{
		}

		private void ApplyAbilityForConsumeBuff(CharacterBase owner, int conditionId)
		{
		}

		private void CheckAbilityForPDLink(CharacterBase owner, CharacterBase from, int actionId, int skillId)
		{
		}

		private void CheckAbilityForChangeBuffTypeCount(CharacterBase owner, int count1, int count2)
		{
		}

		public void Grant(CharacterBase owner, int grantId, int abilityId)
		{
		}

		private void Grant(CharacterBase owner, List<GrantData> list, ActionGrantElement elem, int abilityId)
		{
		}

		public void RemoveGrantAbility(CharacterBase owner, int grantId, int abilityId, RemoveBuffReason reason)
		{
		}

		private void RemoveGrant(CharacterBase owner, AbilityTargetAction targetAction, List<GrantData> list, ActionGrantElement elem, RemoveBuffReason reason)
		{
		}

		private float GetRateBuffDebuff(CharacterBuffType type, bool excludeConditionally = false)
		{
			return default(float);
		}

		public float GetRate(CharacterBuffType type, bool excludeConditionally = false, bool withoutLimit = false, int slipHpGroupId = -1)
		{
			return default(float);
		}

		private BuffType ConvertCharacterBuffTypeToMasterBuffType(CharacterBuffType type)
		{
			return default(BuffType);
		}

		public int GetPercent(CharacterBuffType buffType, bool isBuff, out int rawPercent)
		{
			return default(int);
		}

		public int GetPercent(int buffIconId, bool isBuff, out int rawPercent)
		{
			return default(int);
		}

		public int GetLevel(CharacterBuffType buffType, bool isBuff)
		{
			return default(int);
		}

		public int GetLevel(int buffIconId, bool isBuff)
		{
			return default(int);
		}

		private bool GetLevel(int conditionId, ref int level)
		{
			return default(bool);
		}

		private bool GetLevel(ActionConditionElement ace, ref int level)
		{
			return default(bool);
		}

		public bool GetBuffBullet(CharacterBase chara, int buffIconId, bool isBuff, ref List<StockBulletObject> stockBulletList)
		{
			return default(bool);
		}

		public void GetDurationTime(CharacterBuffType buffType, bool isMax, bool isBuff, out int conditionId, out float durationTime, out float lifeTime, out int durationTimeScale)
		{
		}

		public void GetDurationTime(int buffIconId, bool isMax, out int conditionId, out float durationTime, out float lifeTime, out int durationTimeScale)
		{
		}

		public void GetDurationTime(Parameter buff, ref int conditionId, ref float durationTime, ref float lifeTime, ref int durationTimeScale)
		{
		}

		public int GetBuffDurationNum(CharacterBuffType type, int overWriteGroupId = -1)
		{
			return default(int);
		}

		private float GetExtention(CharacterBase from, CharacterBuffType buffType, int actionId, bool isBuff, ActionConditionElement ace)
		{
			return default(float);
		}

		private bool IsExtentionDebuff(CharacterBuffType buffType)
		{
			return default(bool);
		}

		public float GetHpConsumptionCoef()
		{
			return default(float);
		}

		public bool IsMaxTension()
		{
			return default(bool);
		}

		public bool IsMaxTensionOnSkillStart(ActionStartParameter startParameter)
		{
			return default(bool);
		}

		public bool IsAffectedByTension(CharacterBase owner, int skillId, ActionStartParameter startParameter)
		{
			return default(bool);
		}

		public int GetTensionLevel()
		{
			return default(int);
		}

		public bool IsMaxInspiration()
		{
			return default(bool);
		}

		public bool IsMaxInspirationOnSkillStart(ActionStartParameter startParameter)
		{
			return default(bool);
		}

		public int GetInspirationLevel()
		{
			return default(int);
		}

		public int GetMalaiseLevel(int rate)
		{
			return default(int);
		}

		public int GetMalaiseDamageLimit()
		{
			return default(int);
		}

		public void SetSkillDamageUpOnSkillStart()
		{
		}

		public bool HasBuffDebuffCountByConditionId(int conditionId, int abilityId, int productId)
		{
			return default(bool);
		}

		public int GetBuffCount()
		{
			return default(int);
		}

		public int GetDebuffCount()
		{
			return default(int);
		}

		public int GetDebuffCount_UnableTransform()
		{
			return default(int);
		}

		public int GetCount(CharacterBuffType type, bool isBuff, bool forIcon = false, bool includeSpecifyBuffIcon = false)
		{
			return default(int);
		}

		public int GetCount(CharacterBase curChara, int buffIconId)
		{
			return default(int);
		}

		public int GetBuffCountForConditionId(int conditionId, bool forIcon = false)
		{
			return default(int);
		}

		public int GetBuffTypeCount()
		{
			return default(int);
		}

		public bool IsActivateSkill(CharacterBase owner, int id)
		{
			return default(bool);
		}

		public void Regenerate(CharacterBase owner, Dictionary<CharacterBase, int> froms, CharacterBuffType buffType, int buffIconId, int heal1, int heal2, int heal3, int heal4, int damage1, bool isFollower, bool withSE = true, float dragonTimerDamage = 0f)
		{
		}

		private int GetRecoverySpSlot(CharacterBase owner, int abilityId, int defaultSlot)
		{
			return default(int);
		}

		public static void DispBuffCaption(CharacterBase owner, int actionConditionId)
		{
		}

		private void ApplySlipDamage(int damage, bool isFollower, CharacterBase owner, Dictionary<CharacterBase, int> froms, CharacterBuffType buffType, int buffIconId)
		{
		}

		private bool ApplyDragonTimerSlipDamage(int damage, bool isFollower, CharacterBase owner, CharacterBuffType buffType, int buffIconId, float dragonTimerDamage = 0f)
		{
			return default(bool);
		}

		private void RecoverySpForAutoRegene(CharacterBase owner, int healValue, int skillIndex, bool withSE)
		{
		}

		public static float GetTransitionRate(CharacterBuffType type, ActionConditionElement ace, out int enhancedId)
		{
			return default(float);
		}

		private static bool IsPauseOnDeathBuffDebuff(CharacterBase owner, CharacterBuffType type)
		{
			return default(bool);
		}

		private static bool IsPauseEnhancedBuff(CharacterBase owner, CharacterBuffType type, int conditionId)
		{
			return default(bool);
		}

		private float RecoveryHpCoef(CharacterBase from, int actionId)
		{
			return default(float);
		}

		private bool SetupRegeneration(CharacterBase owner, CharacterBase from, ActionConditionElement ace, int actionId, int abilityId, int skillId, int productId, float durationSec, ActionTargetGroup hitTargetGroup, int requiredRecoverHp, float rateIncreaseByTime, float rateIncreaseDuration, bool fromUnifiedBuff, bool isUnifiedOverwrite = false, int ownerId = 0, AbilityConst.UnitType unitType = AbilityConst.UnitType.None)
		{
			return default(bool);
		}

		private bool RegeneCanOverwriteByGroupId(ActionConditionElement ace, RegenerationType regeneType, Regeneration originRegene, Regeneration overwriteRegene, CharacterBase owner, int abilityId, float coef)
		{
			return default(bool);
		}

		private void PlayBuffEffectOneShot(CharacterBase owner, ActionConditionElement ace)
		{
		}

		private void PlayDebuffEffectOneShot(CharacterBase owner, ActionConditionElement ace)
		{
		}

		private void PlayStartEffect(CharacterBase owner, ActionConditionElement ace, string defaultEffect)
		{
		}

		private void PlayBuffEffect(CharacterBase owner)
		{
		}

		private void PlayDebuffEffect(CharacterBase owner)
		{
		}

		private void PlayDamageShieldEffect(CharacterBase owner)
		{
		}

		private void PlayGuardEffect(CharacterBase owner)
		{
		}

		public void PlayAuraEffect(CharacterBase owner, int id)
		{
		}

		private void PlayAuraEffect(CharacterBase owner, AuraEffectElement aee)
		{
		}

		private void PlayAuraEffect_Default(CharacterBase owner, AuraEffectElement aee, int trigger = 0)
		{
		}

		private void PlayAuraEffect_Element(CharacterBase owner, AuraEffectElement aee)
		{
		}

		private void PlayAuraEffect_IsDragon(CharacterBase owner, AuraEffectElement aee)
		{
		}

		private void PlayAuraEffect_IsLoop(CharacterBase owner, AuraEffectElement aee)
		{
		}

		private void PlayAuraEffect_IsDependOnCp(CharacterBase owner, AuraEffectElement aee)
		{
		}

		public void PlayPowerUpComboEffect(CharacterBase owner, int trg = -1)
		{
		}

		private void PlaySparkingEffect(CharacterBase owner)
		{
		}

		private void PlayDispelProduction(CharacterBase owner)
		{
		}

		private void PlayEffect(CharacterBase owner, string key, string effectName, EffectObject.EraseType eraseType = EffectObject.EraseType.DELETE, int trigger = 0, int auraGroup = 0, bool isDynamicScale = false, [Optional] string bindPos)
		{
		}

		private void KickTrigger(CharacterBase owner, string key, int trigger)
		{
		}

		private static void DispTextForBuffType(CharacterBase owner, CharacterBuffType buffType, int conditionId, float rate, string text, bool isSync = false)
		{
		}

		private static void DispTextForBuffIconId(CharacterBase owner, int buffIcon, float rate, string text, bool isSync = false)
		{
		}

		private static void DispText(CharacterBase owner, BuffCaption.Param.DisplayIconType iconType, int iconElement, CharacterBuffType buffType, int conditionId, float rate, string text, bool isSync = false)
		{
		}

		private string GetText(CharacterBuffType type, ActionConditionElement ace)
		{
			return null;
		}

		public void RestoreEffect(CharacterBase owner)
		{
		}

		public void StopEffect(CharacterBase owner)
		{
		}

		public void StopPowerUpComboEffect(CharacterBase owner, bool isForce)
		{
		}

		public void StopBuffDebuffEffect(CharacterBase owner)
		{
		}

		public void ForceStopEffect(CharacterBase owner)
		{
		}

		private void IsValid(CharacterBase owner)
		{
		}

		private void CheckValid(AuraID auraId, CharacterBuffType buffType, float rate, Parameter.InternalFlagType internalFlag)
		{
		}

		private bool IsConditionally(ActionConditionElement ace)
		{
			return default(bool);
		}

		public bool IsConditionallyElements(CharacterBase owner, ActionConditionElement ace)
		{
			return default(bool);
		}

		public bool HasConditionId(int conditionId)
		{
			return default(bool);
		}

		public bool HasDebuff(CharacterBuffType type)
		{
			return default(bool);
		}

		public bool HasDebuff(ActionDefDebuff typeId, int slipHpGroupId = -1)
		{
			return default(bool);
		}

		public int GetSpecificBuffCount(int actionConditionId)
		{
			return default(int);
		}

		public int GetDuplicatedBuffCount(int specificId = 0)
		{
			return default(int);
		}

		public bool HasAnyBuff()
		{
			return default(bool);
		}

		public bool HasAnyDebuff()
		{
			return default(bool);
		}

		public bool HasAnyBuffOrDebuff()
		{
			return default(bool);
		}

		public bool IsEnableSkillButtonAnimation(int skillId)
		{
			return default(bool);
		}

		public bool HasBurstDamageUp()
		{
			return default(bool);
		}

		public bool HasEnhancedSkillBuff(int idx)
		{
			return default(bool);
		}

		public bool HasDamageCut2()
		{
			return default(bool);
		}

		public bool HasDamageShield(CharacterBuffType damageShieldType)
		{
			return default(bool);
		}

		public bool HasHealInvalid()
		{
			return default(bool);
		}

		public bool HasTensionUpInvalid()
		{
			return default(bool);
		}

		public float CaclulateSkillRecovery(CharacterBase owner, int skillIdx, float value, float originValue, float rate)
		{
			return default(float);
		}

		public bool HasSelfDamage()
		{
			return default(bool);
		}

		public bool HasHpConsumption()
		{
			return default(bool);
		}

		public bool HasDisableAction()
		{
			return default(bool);
		}

		public bool HasDisableMove()
		{
			return default(bool);
		}

		public bool HasComboShift()
		{
			return default(bool);
		}

		public bool HasGoldenBarrier()
		{
			return default(bool);
		}

		public bool HasIronWall()
		{
			return default(bool);
		}

		public bool HasVesselBomb(CharacterBase owner, CharacterBase from, int conditionId, out int count)
		{
			return default(bool);
		}

		public bool HasDisableActionFlag(InGameDef.ActionFlag flag)
		{
			return default(bool);
		}

		public void ExecDamageLink(CharacterBase owner)
		{
		}

		public void ExecAdditionAttack(CharacterBase owner, CollisionHitAttribute hitAttribute)
		{
		}

		public void ConditionallyList(CharacterBuffType type, out List<int> list)
		{
		}

		public void RemoveZombieBuff(CharacterBase owner)
		{
		}

		private bool GetRateMinMax(CharacterBuffType type, out float min, out float max)
		{
			return default(bool);
		}

		private int CreateMultiPlayKey(CharacterBase owner)
		{
			return default(int);
		}

		private List<GrantData> GetGrantDataList(AbilityTargetAction targetAction)
		{
			return null;
		}

		private bool IsDuplicatableBuffType(CharacterBuffType type)
		{
			return default(bool);
		}

		public static bool IsDuplicatableAlways(ActionConditionElement ace)
		{
			return default(bool);
		}

		public static bool IsOverwritableAlways(ActionConditionElement ace)
		{
			return default(bool);
		}

		private bool IsRegene(CharacterBuffType type)
		{
			return default(bool);
		}

		private bool IsRegeneDebuff(CharacterBuffType type)
		{
			return default(bool);
		}

		private bool IsDamageShield(CharacterBuffType type)
		{
			return default(bool);
		}

		private bool IsSacrificeShield(CharacterBuffType type)
		{
			return default(bool);
		}

		public bool IsShieldSeries(CharacterBuffType type)
		{
			return default(bool);
		}

		private void PostApplyParameterBuff(CharacterBase owner, CharacterBase from, CharacterBuffType buffType, Parameter buffDebuff, ActionConditionElement ace, int actionId, bool isShowEffect, bool isSyncData)
		{
		}

		public void SetHitData(ActionConditionElement elem, CharacterBase from, int actionId, int skillId, int productId, int type, bool isUnifiedBuff, int buffExplosionHitId)
		{
		}

		public bool CheckHitData(ActionConditionElement elem, CharacterBase from, int actionId, int skillId, int productId, int type, bool isUnifiedBuff, bool isBuffDebuffFieldHit, int buffExplosionHitId)
		{
			return default(bool);
		}

		public void RemoveHitData(CollisionHitAttribute attr)
		{
		}

		private void ReadParameterSyncData(CharacterBase owner, List<ParameterSyncData> addParameters, List<RemoveSyncData> removeParameters)
		{
		}

		private void ReadRegenerationSyncData(CharacterBase owner, List<RegenerationSyncData> addRegeneration, List<RemoveSyncData> removeRegeneration)
		{
		}

		private void ReadGrantSyncData(CharacterBase owner, List<GrantSyncData> addGrants, List<RemoveSyncData> removeGrants)
		{
		}

		private void ReadAddGrantSyncData(CharacterBase owner, AbilityTargetAction targetAction, List<GrantData> list, GrantSyncData grant)
		{
		}

		private bool ReadRemoveGrantSyncData(CharacterBase owner, AbilityTargetAction targetAction, List<GrantData> list, RemoveSyncData removeData)
		{
			return default(bool);
		}

		private void ReadUnifiedParameterSyncData(CharacterBase owner, List<UnifiedParameterSyncData> addUnifiedParameters, List<RemoveSyncData> removeUnifiedParameters)
		{
		}

		private void RecoveryHpBuff(CharacterBase owner, float rate, int actionId, bool needSync)
		{
		}

		public void RecoveryHpConditionallyAbility(CharacterBase owner, int hp, bool needSync)
		{
		}

		private void Dispel(CharacterBase owner, CharacterBase from, ActionConditionElement ace, int actionId, int skillId, int productId, [Optional] CharacterBuffType[] excludeTypes, int buffExplosionHitId = 0)
		{
		}

		private void CheckDispelProductionForReceiver(CharacterBase owner, CharacterBase from, int conditionId, int actionId, int skillId, int productId, [Optional] CharacterBuffType[] excludeTypes, int buffExplosionHitId = 0)
		{
		}

		private BuffUnion FindDispelTarget(CharacterBase owner, [Optional] CharacterBuffType[] excludeTypes)
		{
			return default(BuffUnion);
		}

		public void RemoveBuffDebuffByRecoveryHp(CharacterBase owner, int value)
		{
		}

		public void SetSacrificeShieldHp(CharacterBase owner, float hp, int followerAvoid = -1)
		{
		}

		public void ReduceSacrificeShieldHp(CharacterBase owner, float hp, bool needSync, int followerAvoid = -1)
		{
		}

		private void SendReduceSacrificeShieldHp(float hp, CharacterBase owner)
		{
		}

		public void ReciveReduceSacrificeShieldHp(float hp, CharacterBase owner)
		{
		}

		private bool IsNoSyncBuff(int conditionId)
		{
			return default(bool);
		}

		private bool CanRemoveCategoryDebuff(int targetDebuffCategory, ActionConditionElement ace, RemoveBuffReason reason)
		{
			return default(bool);
		}

		public void OnReturnEnemyToPool(EnemyCharacter enemy)
		{
		}

		public void SetRecoveryOpeningDebuff(CharacterBase owner, int conditionId, CharacterBase from)
		{
		}

		private void UpdateOpeningDebuff(CharacterBase owner)
		{
		}

		public void OnReceiveApplyOpeningDebuffEvent(CharacterBase owner, ApplyOpeningDebuffEvent recvEvent)
		{
		}

		public void OnApplyOpeningDebuff(CharacterBase owner, bool applied, int conditionId, CharacterBase from)
		{
		}

		public static bool IsChangeBuffDurationBuff(CharacterBuffType type)
		{
			return default(bool);
		}

		public void OnRecieveChangeBuffDuration(CharacterBase owner, ChangeBuffDuration recvEvent)
		{
		}
	}
}
