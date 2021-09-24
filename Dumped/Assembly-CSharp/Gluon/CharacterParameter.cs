/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterParameter
	{
		// Fields
		public static readonly int targetActionNum;
		public static readonly int abnormalStatusNum;
		public static readonly int tribeNum;
		private static readonly int elementalNum;
		public static readonly int overflowSpRate;
		private bool _isUpdate;
		private bool _isPause;
		[CompilerGenerated]
		private ObscuredInt _level_k__BackingField;
		[CompilerGenerated]
		private ObscuredInt _currHp_k__BackingField;
		public ObscuredInt[] currSp;
		public ObscuredInt[] consumeSp;
		[CompilerGenerated]
		private ObscuredInt _currShp_k__BackingField;
		private ObscuredInt[] currEp;
		private bool[] availableEp;
		[CompilerGenerated]
		private UtpCtrl _utp_k__BackingField;
		[CompilerGenerated]
		private float _dragonDamageCoef_k__BackingField;
		[CompilerGenerated]
		private int _dragonReliability_k__BackingField;
		[CompilerGenerated]
		private float _eventBoost_k__BackingField;
		[CompilerGenerated]
		private bool _isWeakInvalid_k__BackingField;
		[CompilerGenerated]
		private bool _isReraise_k__BackingField;
		[CompilerGenerated]
		private bool _isArmored_k__BackingField;
		private Dictionary<int, float> tempUniqueDict;
		public FluctuationParameter total;
		public FluctuationParameter immutable;
		public FluctuationParameter origin;
		public FluctuationParameter weapon;
		public FluctuationParameter dragon;
		public FluctuationParameter amulet;
		public FluctuationParameter fortFixed;
		public FluctuationParameter fortRatio;
		public FluctuationParameter albumRatio;
		public FluctuationParameter ability;
		public FluctuationParameter abilityImmutable;
		public FluctuationParameter abilityConditionally;
		public FluctuationParameter amuletAbility;
		public FluctuationParameter amuletAbilityImmutable;
		public FluctuationParameter amuletAbilityConditionally;
		public FluctuationParameter unionBonus;
		public FluctuationParameter unionBonusImmutable;
		public FluctuationParameter unionBonusConditionally;
		public FluctuationParameter exAbility;
		public FluctuationParameter buffAndAura;
		public FluctuationParameter activeGauge;
		public FluctuationParameter eventPassive;
		public FluctuationParameter aura;
		public FluctuationParameter buff;
		[CompilerGenerated]
		private CharacterBuff _buffCtrl_k__BackingField;
		[CompilerGenerated]
		private Ability _abilityCtrl_k__BackingField;
		[CompilerGenerated]
		private ExAbility _exAbilityCtrl_k__BackingField;
		[CompilerGenerated]
		private ActiveGaugeAbility _activeGaugeCtrl_k__BackingField;
		[CompilerGenerated]
		private CharacterAuraCtrl _auraCtrl_k__BackingField;
		public CharacterCustomPointController customPointController;
		[CompilerGenerated]
		private BRCharaCtrl _brCharaCtrl_k__BackingField;
	
		// Properties
		public bool isUpdate { get; set; }
		public bool isPause { get; set; }
		public ObscuredInt level { [CompilerGenerated] get; [CompilerGenerated] set; }
		public ObscuredInt currHp { [CompilerGenerated] get; [CompilerGenerated] set; }
		public ObscuredInt currShp { [CompilerGenerated] get; [CompilerGenerated] set; }
		public UtpCtrl utp { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float dragonDamageCoef { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int dragonReliability { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float eventBoost { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isWeakInvalid { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isReraise { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isArmored { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public CharacterBuff buffCtrl { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Ability abilityCtrl { [CompilerGenerated] get; [CompilerGenerated] set; }
		public ExAbility exAbilityCtrl { [CompilerGenerated] get; [CompilerGenerated] set; }
		public ActiveGaugeAbility activeGaugeCtrl { [CompilerGenerated] get; [CompilerGenerated] set; }
		public CharacterAuraCtrl auraCtrl { [CompilerGenerated] get; [CompilerGenerated] set; }
		public BRCharaCtrl brCharaCtrl { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public class ActionParam
		{
			// Fields
			public float actionPower;
			public float actionPowerDown;
			public float critical;
			public float criticalForSkillAbility;
			public float recoveryHP;
			public float recoveryHP2;
			public float breakGauge;
			public float breakPower;
			public float[] abnormalAdd;
			public float buffExtension;
			public float debuffExtension;
			public float[] abnormalExtension;
			public float crisisRate;
			public Dictionary<int, float> actionPowerDependsOnHitCount;
			public Dictionary<int, float> criticalUpForDebuffEnemy;
			public Dictionary<int, float> criticalUpForAbnormalStatusEnemy;
			public Dictionary<int, float> criticalDamageUprForAbnormalStatusEnemy;
	
			// Constructors
			public ActionParam();
	
			// Methods
			public void Initialize();
		}
	
		public struct EnemyHpPower
		{
			// Fields
			public float value;
			public float enemyHpRate;
		}
	
		public class FluctuationParameter
		{
			// Fields
			public float hp;
			public float[] sp;
			public float[] ep;
			public float shp;
			public float attack;
			public float defense;
			public float defenseB;
			public float moveSpeed;
			public float moveSpeedRate;
			public float moveSpeedRateB;
			public float attackSpeed;
			public float chargeSpeed;
			public float burstSpeed;
			public float chargeTime;
			public float dragonTime;
			public float dragonTimeRate;
			public float dragonTimeForParty;
			public float dragonTimeSpeedRate;
			public float recoverySP;
			public float recoveryDP;
			public float recoveryUtp;
			public float[] abnormalResist;
			public float damageCut;
			public float damageCutB;
			public float damageCutTrap;
			public float[] damageShield;
			public float enhancedCritical;
			public ActionParam[] actionParam;
			public float[] enhancedElement;
			public float[] enhancedElement2;
			public float enhancedDisadvantagedElement;
			public float[] resistElement;
			public float[] tribeKiller;
			public float[] resistTribe;
			public float[] abnormalKiller;
			public float[] abnormalKillerDependsOnTypeCount;
			public List<int> enemyAbilityKiller;
			public Dictionary<int, float> uniqueKillerDict;
			public Dictionary<int, float> resistUniqueDict;
			public float overdrivekiller;
			public float modeGaugeSuppression;
			public float debuffSlipHp;
			public float debuffGrantRate;
			public float[] debuffKiller;
			public float debuffTimeExtensionForSpecificDebuffs;
			public float dragonDamageUp;
			public float hpDrain;
			public float chainTimeExtension;
			public float rebornHpRatioUp;
			public EnemyHpPower enemyHpMorePower;
			public EnemyHpPower enemyHpLessPower;
			public float needDpRate;
			public float consumeDpRate;
			public float finalDragonTimeRate;
			public float autoAvoidProbability;
			public float criticalAddRateMaxLimit;
	
			// Constructors
			public FluctuationParameter();
	
			// Methods
			public void Initialize();
			public void SetData(FluctuationParameter setData);
			public void AddData(FluctuationParameter addData);
			public void SubData(FluctuationParameter subData);
			public void MulData(FluctuationParameter mulData);
			public void CeilData();
			public void SetValue(float value);
			public void Release();
		}
	
		// Constructors
		public CharacterParameter();
		static CharacterParameter();
	
		// Methods
		public void Initialize(bool isPlayerCharacter);
		public void InitializeCurrentParameter(CharacterBase owner);
		private void InitializeAbilityParameter(ref FluctuationParameter param);
		public void InitializeForBR(PlayerCharacter chara);
		public void CeilFortRatio();
		public void CeilAlbumRatio();
		public void Update(CharacterBase owner, bool timerUpdate);
		public void CalculateTotalParameter(CharacterBase owner, FluctuationParameter total, FluctuationParameter ability, FluctuationParameter fortRatio, FluctuationParameter albumRatio, FluctuationParameter immutable, FluctuationParameter exAbility, FluctuationParameter buffAndAura);
		private void CalculateParameter(CharacterBase owner, bool timerUpdate);
		public void CalculateParameter_BuffDebuffAll(CharacterBase owner);
		public void CalculateOtherParameter();
		private void UpdateAbility(CharacterBase owner, bool timerUpdate);
		private void ApplyAbilityParameterLimit();
		private void ApplyAbilityParameterLimit(AbilityLimitCalculation limitData, ref FluctuationParameter param, FluctuationParameter a, FluctuationParameter b);
		public void CalculateParameter_BuffDebuff(CharacterBase owner, CharacterBuffType buffType, bool calcuTotal = false);
		public void CalculateParameter_BuffDebuff_ToParts(CharacterBase owner, CharacterBuffType buffType);
		public void CalculateAbnormalResist();
		public float GetBurstAttackDamageRateExceptBuffAndAura();
		private void CalculateUnique(ref Dictionary<int, float> dict, Dictionary<int, float> e);
		public void CalculateEnemyAbilityKiller(List<int> list);
		public void CalculateAbilityDragonTimeForParty();
		public float GetActionPowerDependsOnHitCount(CharacterBase owner, int targetActionId);
		public float GetCriticalDamageUpDependsOnEnemyAbnormalStatus(CharacterBase src, CharacterBase dst, int actionId);
		public void SetBuffDefaultValueZero();
		public void ActivateReraise(CharacterBase owner, RemoveBuffReason reason);
		public void ReleaseParameter();
		public void SetRequireSp(CharacterBase owner, int sp, int skillIndex);
		public void SetEp(CharacterBase owner, int value, int index);
		public int GetEp(int index);
		private int GetConsumeEp(CharacterBase owner, int index);
		public int GetEpNum();
		private void SetAvailableEp(int ep, int consumeEp, int index);
		public bool IsAvailableEp(int index);
	}
}
