using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;

namespace Gluon
{
	public class CharacterParameter
	{
		public class ActionParam
		{
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

			public float spGainCut;

			public Dictionary<int, float> actionPowerDependsOnHitCount;

			public Dictionary<int, float> criticalUpForDebuffEnemy;

			public Dictionary<int, float> criticalUpForAbnormalStatusEnemy;

			public Dictionary<int, float> criticalDamageUprForAbnormalStatusEnemy;

			public void Initialize()
			{
			}
		}

		public struct EnemyHpPower
		{
			public float value;

			public float enemyHpRate;
		}

		public class FluctuationParameter
		{
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

			public void Initialize()
			{
			}

			public void SetData(FluctuationParameter setData)
			{
			}

			public void AddData(FluctuationParameter addData)
			{
			}

			public void SubData(FluctuationParameter subData)
			{
			}

			public void MulData(FluctuationParameter mulData)
			{
			}

			public void CeilData()
			{
			}

			public void SetValue(float value)
			{
			}

			public void Release()
			{
			}
		}

		public static readonly int targetActionNum;

		public static readonly int abnormalStatusNum;

		public static readonly int tribeNum;

		private static readonly int elementalNum;

		public static readonly int overflowSpRate;

		private bool _isUpdate;

		private bool _isPause;

		public ObscuredInt[] currSp;

		public ObscuredInt[] consumeSp;

		private ObscuredInt[] currEp;

		private bool[] availableEp;

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

		public CharacterCustomPointController customPointController;

		public bool isUpdate
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool isPause
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public ObscuredInt level
		{
			[CompilerGenerated]
			get
			{
				return default(ObscuredInt);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public ObscuredInt currHp
		{
			[CompilerGenerated]
			get
			{
				return default(ObscuredInt);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public ObscuredInt currShp
		{
			[CompilerGenerated]
			get
			{
				return default(ObscuredInt);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public UtpCtrl utp
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

		public float dragonDamageCoef
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

		public int dragonReliability
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

		public float eventBoost
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

		public bool isWeakInvalid
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

		public bool isReraise
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

		public bool isArmored
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

		public CharacterBuff buffCtrl
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

		public Ability abilityCtrl
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

		public ExAbility exAbilityCtrl
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

		public ActiveGaugeAbility activeGaugeCtrl
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

		public CharacterAuraCtrl auraCtrl
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

		public BRCharaCtrl brCharaCtrl
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

		public void Initialize(bool isPlayerCharacter)
		{
		}

		public void InitializeCurrentParameter(CharacterBase owner)
		{
		}

		private void InitializeAbilityParameter(ref FluctuationParameter param)
		{
		}

		public void InitializeForBR(PlayerCharacter chara)
		{
		}

		public void CeilFortRatio()
		{
		}

		public void CeilAlbumRatio()
		{
		}

		public void Update(CharacterBase owner, bool timerUpdate)
		{
		}

		public void CalculateTotalParameter(CharacterBase owner, FluctuationParameter total, FluctuationParameter ability, FluctuationParameter fortRatio, FluctuationParameter albumRatio, FluctuationParameter immutable, FluctuationParameter exAbility, FluctuationParameter buffAndAura)
		{
		}

		private void CalculateParameter(CharacterBase owner, bool timerUpdate)
		{
		}

		public void CalculateParameter_BuffDebuffAll(CharacterBase owner)
		{
		}

		public void CalculateOtherParameter()
		{
		}

		private void UpdateAbility(CharacterBase owner, bool timerUpdate)
		{
		}

		private void ApplyAbilityParameterLimit()
		{
		}

		private void ApplyAbilityParameterLimit(AbilityLimitCalculation limitData, ref FluctuationParameter param, FluctuationParameter a, FluctuationParameter b)
		{
		}

		public void CalculateParameter_BuffDebuff(CharacterBase owner, CharacterBuffType buffType, bool calcuTotal = false)
		{
		}

		public void CalculateParameter_BuffDebuff_ToParts(CharacterBase owner, CharacterBuffType buffType)
		{
		}

		public void CalculateAbnormalResist()
		{
		}

		public float GetBurstAttackDamageRateExceptBuffAndAura()
		{
			return default(float);
		}

		private void CalculateUnique(ref Dictionary<int, float> dict, Dictionary<int, float>.Enumerator e)
		{
		}

		public void CalculateEnemyAbilityKiller(List<int> list)
		{
		}

		public void CalculateAbilityDragonTimeForParty()
		{
		}

		public float GetActionPowerDependsOnHitCount(CharacterBase owner, int targetActionId)
		{
			return default(float);
		}

		public float GetCriticalDamageUpDependsOnEnemyAbnormalStatus(CharacterBase src, CharacterBase dst, int actionId)
		{
			return default(float);
		}

		public void SetBuffDefaultValueZero()
		{
		}

		public void ActivateReraise(CharacterBase owner, RemoveBuffReason reason)
		{
		}

		public void ReleaseParameter()
		{
		}

		public void SetRequireSp(CharacterBase owner, int sp, int skillIndex)
		{
		}

		public void SetEp(CharacterBase owner, int value, int index)
		{
		}

		public int GetEp(int index)
		{
			return default(int);
		}

		private int GetConsumeEp(CharacterBase owner, int index)
		{
			return default(int);
		}

		public int GetEpNum()
		{
			return default(int);
		}

		private void SetAvailableEp(int ep, int consumeEp, int index)
		{
		}

		public bool IsAvailableEp(int index)
		{
			return default(bool);
		}
	}
}
