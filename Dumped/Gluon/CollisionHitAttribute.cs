using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public sealed class CollisionHitAttribute : CollisionTransform
	{
		public struct CreateParam
		{
			public InGameDef.CharacterType characterType;

			public int elementIndex;

			public int actionId;

			public int skillId;

			public int bulletId;

			public int productId;

			public void Setup(InGameDef.CharacterType characterType, int elementIndex, int actionId, int skillId, int bulletId, int productId)
			{
			}
		}

		public struct AdditionalAttackParam
		{
			public int attackWhenBuffReceived;

			public float hitAttrAttackPower;

			public string effect;

			public CharacterBase owner;

			public string hitAttrId;

			public int actionId;

			public int skillId;

			public int penetrateCount;

			public float attenuationRate;
		}

		public enum CriticalStatus
		{
			Normal,
			Guaranteed,
			Failed
		}

		public static readonly string debuffSelfDamage;

		public static readonly string substitudeDamage;

		public static readonly string timeStopDamage;

		public static readonly string brTouchHit;

		public static readonly string debugDamage;

		public const uint BR_EXCLUSION_ID = 549165420u;

		public int hitStopAcceptIndex;

		private CreateParam _createParam;

		public AdditionalAttackParam additionalAttackParam;

		[SerializeField]
		private string _Id;

		[SerializeField]
		private ActionHitExecType _HitExecType;

		[SerializeField]
		private ActionTargetGroup _HitTargetGroup;

		[SerializeField]
		private ElementalType _Elemental01;

		[SerializeField]
		private ElementalType _HitTargetElemental;

		[SerializeField]
		private ElementalType _Elemental02;

		[SerializeField]
		private int _Attributes02;

		[SerializeField]
		private int _Attributes03;

		[SerializeField]
		private LookToDamageType _LookToDamageType;

		[SerializeField]
		private int _Attributes04;

		[SerializeField]
		private int _Attributes05;

		[SerializeField]
		private int _Attributes07;

		[SerializeField]
		private int _Attributes08;

		[SerializeField]
		private int _AttrOrderBarrer;

		[SerializeField]
		private int _AttrIgnoreBarrier;

		[SerializeField]
		private int _AttrNoReaction;

		[SerializeField]
		private int _AttrDragon;

		[SerializeField]
		private int _AttrPenetrateShield;

		[SerializeField]
		private int _AttrDisallowRecovery;

		[SerializeField]
		private float _DamageAdjustment;

		[SerializeField]
		private float _DamageAdjustmentForFollower;

		[SerializeField]
		private float _AbilityFactor;

		[SerializeField]
		private float _ToOdDmgRate;

		[SerializeField]
		private float _ToBreakDmgRate;

		[SerializeField]
		private float _ToEightDownRate;

		[SerializeField]
		private float _AdditionCritical;

		[SerializeField]
		private List<string> _AdditionalRandomHitLabel;

		[SerializeField]
		private int _AdditionalRandomHitNum;

		[SerializeField]
		private bool _IsDamageMyself;

		[SerializeField]
		private float _SetCurrentHpRate;

		[SerializeField]
		private float _ConsumeHpRate;

		[SerializeField]
		private int _DamageSelfUpFromBuffCountBuffId;

		[SerializeField]
		private bool _IsSubstitudeDamage;

		[SerializeField]
		private int _RecoveryValue;

		[SerializeField]
		private int _AdditionRecoverySp;

		[SerializeField]
		private float _RecoverySpRatio;

		[SerializeField]
		private int _RecoverySpSkillIndex;

		[SerializeField]
		private int _AdditionRecoveryDp;

		[SerializeField]
		private int _AdditionRecoveryDpAbility;

		[SerializeField]
		private float _AdditionRecoveryDpPercentage;

		[SerializeField]
		private float _RecoveryDragonTime;

		[SerializeField]
		private int _RecoveryEp;

		[SerializeField]
		private int _RecoveryCP;

		[SerializeField]
		private int _RecoveryCPIndex;

		[SerializeField]
		private int _RecoveryCPEveryHit;

		[SerializeField]
		private int _AdditionRecoveryUtp;

		[SerializeField]
		private int _AddUtp;

		[SerializeField]
		private bool _IgnoreHitCountAddition;

		[SerializeField]
		private bool _IgnoreFirstHitCheck;

		[SerializeField]
		private float _HpDrainRate;

		[SerializeField]
		private float _HpDrainRate2;

		[SerializeField]
		private float _HpDrainLimitRate;

		[SerializeField]
		private string _HpDrainAttribute;

		[SerializeField]
		private float _DamageCounterCoef;

		[SerializeField]
		private float _CrisisLimitRate;

		[SerializeField]
		private float _DamageDispDelaySec;

		[SerializeField]
		private bool _IsDisableHealSpOnCurse;

		[SerializeField]
		private string _HeadText;

		[SerializeField]
		private string _BattleLogText;

		[SerializeField]
		private int _SplitDamageCount;

		[SerializeField]
		private int _SplitDamageCount2;

		[SerializeField]
		private int _ActionCondition;

		[SerializeField]
		private int _ActionGrant;

		[SerializeField]
		private int _AuraId;

		[SerializeField]
		private int _AuraMaxLimitLevel;

		[SerializeField]
		private AuraConst.TargetType _AuraTargetType;

		[SerializeField]
		private int _KillerState1;

		[SerializeField]
		private int _KillerState2;

		[SerializeField]
		private int _KillerState3;

		[SerializeField]
		private float _KillerStateDamageRate;

		[SerializeField]
		private string _KillerStateDamageRateCurveDependsOnHitCount;

		[SerializeField]
		private float _KillerStateRelease;

		[SerializeField]
		private float _DamageUpRateByBuffCount;

		[SerializeField]
		private int _DamageUpDataByBuffCount;

		[SerializeField]
		private int _ArmorBreakLv;

		[SerializeField]
		private int _InvincibleBreakLv;

		[SerializeField]
		private ActionKnockBackType _KnockBackType;

		[SerializeField]
		private float _KnockBackDistance;

		[SerializeField]
		private int _KnockBackDependsOnMass;

		[SerializeField]
		private float _KnockBackDurationSec;

		[SerializeField]
		private float _BlastHeight;

		[SerializeField]
		private float _BlastAngle;

		[SerializeField]
		private float _BlastGravity;

		[SerializeField]
		private ActionCollision _Collision;

		[SerializeField]
		private float _CollisionLength;

		[SerializeField]
		private float _CollisionFan;

		[SerializeField]
		private float _CollisionWidth;

		[SerializeField]
		private float _CollisionHeight;

		[SerializeField]
		private string _FontEffect;

		[SerializeField]
		private int _FollowerAvoidProbability;

		[SerializeField]
		private FollowerAvoidType _FollowerAvoidType;

		[SerializeField]
		private bool _UseDamageMotionTimeScale;

		[SerializeField]
		private float _DamageMotionTimeScale;

		[SerializeField]
		private bool _IsShare;

		[SerializeField]
		private bool _IsCancelTransform;

		[SerializeField]
		private bool _IsCancelBind;

		[SerializeField]
		private int _FixedDamage;

		[SerializeField]
		private int _CurrentHpRateDamage;

		[SerializeField]
		private int _MaxHpRateDamage;

		[SerializeField]
		private bool _IsKillHpRateDamage;

		[SerializeField]
		private int _AdditionActiveGaugeValue;

		[SerializeField]
		private bool _IsAddElectrify;

		[SerializeField]
		private PlayerHitCondition _HitConditionType;

		[SerializeField]
		private int _HitConditionP1;

		[SerializeField]
		private int _HitConditionP2;

		[SerializeField]
		private bool _IsAddCombo;

		[SerializeField]
		private bool _IsAdditionalAttackToEnemy;

		[SerializeField]
		private int _ODCounterType;

		[SerializeField]
		private int _ODCounterBonus;

		[SerializeField]
		private int _CutDpRate;

		[SerializeField]
		private int _CutUtpRate;

		[SerializeField]
		private int _ParticularTargetId;

		public int penetrateCount
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

		public float attenuationRate
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

		public CharacterBase.HitProduction exceptHitProduction
		{
			[CompilerGenerated]
			get
			{
				return default(CharacterBase.HitProduction);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public ICollideCallback collideCallback
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

		public Action<int> onHitCountAdded
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

		public CharacterBase Owner => null;

		public CharacterBase CollisionAttachChara => null;

		public InGameDef.CharacterType characterType => default(InGameDef.CharacterType);

		public CharacterBase.HitType hitType => default(CharacterBase.HitType);

		public int actionId => default(int);

		public int skillId => default(int);

		public int bulletId => default(int);

		public int actionProductId => default(int);

		public int sameTimeHitId
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

		public bool useSelfPosAsWallCheckOrigin
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

		public bool useCustomWallCheckFromPos
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

		public Vector3 customWallCheckFromPos
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Dictionary<CharacterBase, DamageCalculation.DamageStatus> fixedValueForCalc
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

		public bool isQuestSkill
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

		public bool enableApplyMultipleDebuff
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

		public CriticalStatus criticalStatus
		{
			[CompilerGenerated]
			get
			{
				return default(CriticalStatus);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsAbsorptionKnockBack => default(bool);

		public bool IsAbsorptionKnockBackByEnemyAbility => default(bool);

		public bool IsHealSpHitExecType => default(bool);

		public string Id => null;

		public ActionHitExecType HitExecType => default(ActionHitExecType);

		public ActionTargetGroup HitTargetGroup => default(ActionTargetGroup);

		public ElementalType HitTargetElemental => default(ElementalType);

		public ElementalType Elemental01 => default(ElementalType);

		public ElementalType Elemental02 => default(ElementalType);

		public int Attributes02 => default(int);

		public int Attributes03 => default(int);

		public LookToDamageType LookToDamageType => default(LookToDamageType);

		public int Attributes04 => default(int);

		public int Attributes05 => default(int);

		public int Attributes07 => default(int);

		public int Attributes08 => default(int);

		public int AttrOrderBarrer => default(int);

		public int AttrIgnoreBarrier => default(int);

		public int AttrNoReaction => default(int);

		public int AttrDragon => default(int);

		public bool IsPenetrateShield => default(bool);

		public bool IsDisallowRecovery => default(bool);

		public float DamageAdjustment
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float DamageAdjustmentForFollower
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float AbilityFactor
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float ToOdDmgRate => default(float);

		public float ToBreakDmgRate => default(float);

		public float ToEightDownRate => default(float);

		public float AdditionCritical => default(float);

		public List<string> AdditionalRandomHitLabel => null;

		public int AdditionalRandomHitNum => default(int);

		public bool IsDamageMyself => default(bool);

		public float SetCurrentHpRate => default(float);

		public float ConsumeHpRate => default(float);

		public int DamageSelfUpFromBuffCountBuffId => default(int);

		public bool IsSubstitudeDamage => default(bool);

		public int RecoveryValue => default(int);

		public int AdditionRecoverySp => default(int);

		public float RecoverySpRatio => default(float);

		public int RecoverySpSkillIndex => default(int);

		public int AdditionRecoveryDp => default(int);

		public int AdditionRecoveryDpAbility => default(int);

		public float AdditionRecoveryDpPercentage => default(float);

		public float RecoveryDragonTime => default(float);

		public int RecoveryEp => default(int);

		public int RecoveryCP => default(int);

		public int RecoveryCPIndex => default(int);

		public int RecoveryCPEveryHit => default(int);

		public int AdditionRecoveryUtp => default(int);

		public int AddUtp => default(int);

		public bool IgnoreHitCountAddition => default(bool);

		public bool IgnoreFirstHitCheck => default(bool);

		public float HpDrainRate => default(float);

		public float HpDrainRate2 => default(float);

		public float HpDrainLimitRate
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public string HpDrainAttribute => null;

		public float DamageCounterCoef => default(float);

		public float CrisisLimitRate => default(float);

		public float DamageDispDelaySec
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool IsDisableHealSpOnCurse => default(bool);

		public string HeadText => null;

		public string BattleLogText => null;

		public int SplitDamageCount => default(int);

		public int SplitDamageCount2 => default(int);

		public int ActionCondition => default(int);

		public int ActionGrant => default(int);

		public int AuraId => default(int);

		public int AuraMaxLimitLevel => default(int);

		public AuraConst.TargetType AuraTargetType => default(AuraConst.TargetType);

		public int KillerState1 => default(int);

		public int KillerState2 => default(int);

		public int KillerState3 => default(int);

		public float KillerStateDamageRate => default(float);

		public string KillerStateDamageRateCurveDependsOnHitCount => null;

		public float KillerStateRelease => default(float);

		public float DamageUpRateByBuffCount => default(float);

		public int DamageUpDataByBuffCount => default(int);

		public int ArmorBreakLv => default(int);

		public int InvincibleBreakLv
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public ActionKnockBackType KnockBackType => default(ActionKnockBackType);

		public float KnockBackDistance => default(float);

		public int KnockBackDependsOnMass => default(int);

		public float KnockBackDurationSec => default(float);

		public float BlastHeight => default(float);

		public float BlastAngle => default(float);

		public float BlastGravity => default(float);

		public ActionCollision Collision
		{
			get
			{
				return default(ActionCollision);
			}
			set
			{
			}
		}

		public float CollisionLength
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float CollisionFan
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float CollisionAngle
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float CollisionWidth
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float CollisionHeight
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public string FontEffect => null;

		public int FollowerAvoidProbability => default(int);

		public FollowerAvoidType FollowerAvoidType => default(FollowerAvoidType);

		public bool UseDamageMotionTimeScale => default(bool);

		public float DamageMotionTimeScale => default(float);

		public bool IsShare => default(bool);

		public bool IsCancelTransform => default(bool);

		public bool IsCancelBind => default(bool);

		public int CurrentHpRateDamage => default(int);

		public int MaxHpRateDamage => default(int);

		public bool IsKillHpRateDamage => default(bool);

		public int AdditionActiveGaugeValue => default(int);

		public bool IsAddElectrify => default(bool);

		public PlayerHitCondition HitConditionType => default(PlayerHitCondition);

		public int HitConditionP1 => default(int);

		public int HitConditionP2 => default(int);

		public bool IsAddCombo => default(bool);

		public bool IsAdditionalAttackToEnemy
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public int ODCounterType => default(int);

		public int ODCounterBonus => default(int);

		public int CutDpRate => default(int);

		public int CutUtpRate => default(int);

		public int ParticularTargetId => default(int);

		public int FixedDamage
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public float hpDrainValue
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

		public float hpDrainBuffValue
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

		public CharacterBase hpDrainTarget
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

		public float selfDamageHpRate
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

		public bool isTimeStopDamage
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

		public ActionStartParameter actionStartParam
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

		public bool isCheckCollisionOnDefenceSide
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

		public uint exclusionId
		{
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isBuffDebuffFieldHit
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

		public int buffExplosionHitId
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

		public bool fromLinkAbility
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

		public List<CommonObjectStatus> hitFixedObjects
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

		public bool isFirstHitFinished
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

		public CreateParam GetCreateParam()
		{
			return default(CreateParam);
		}

		public void SetOwner(CharacterBase owner)
		{
		}

		private void ResetHpDrain()
		{
		}

		public override void Clear()
		{
		}

		public static CollisionHitAttribute FromPlayActionHitAttribute(int actionId, int skillId, int bulletId, int productId, string elementId)
		{
			return null;
		}

		public void Startup(int actionId, int skillId, int bulletId, int productId, Tuple<int, PlayerActionHitAttributeElement> pair)
		{
		}

		public static CollisionHitAttribute FromEnemyActionHitAttribute(int actionId, int bulletId, int productId, string elementId)
		{
			return null;
		}

		public void Startup(int actionId, int bulletId, int productId, Tuple<int, EnemyActionHitAttributeElement> pair)
		{
		}

		public static CollisionHitAttribute FromCommonActionHitAttribute(int actionId, int bulletId, string elementId)
		{
			return null;
		}

		public void Startup(int actionId, int bulletId, Tuple<int, CommonActionHitAttributeElement> pair)
		{
		}

		public static bool Create(CreateParam param, ref CollisionHitAttribute outResult)
		{
			return default(bool);
		}

		public void Init(CharacterBase owner, [Optional] CharacterBase attachChara, [Optional] GameObject target)
		{
		}

		public void Init(CharacterBase owner, Vector3 startPos, Vector3 forward, [Optional] CharacterBase attachChara, [Optional] GameObject target)
		{
		}

		public void Init(Vector3 startPos, Vector3 forward)
		{
		}

		public void SetTransform(Vector3 pos, Vector3 forward, bool resetPrevPos = false)
		{
		}

		public void CalcTransform(Vector3 pos, Vector3 forward, bool resetPrevPos = false)
		{
		}

		public void SetForwardOffset(float length)
		{
		}

		public void SetupActionStartParam(CharacterBase owner, ActionContainer container)
		{
		}

		public bool NeedSyncHit()
		{
			return default(bool);
		}

		public bool IsCheckCollisionOnDefenceSide()
		{
			return default(bool);
		}

		public bool IsDamageTransform()
		{
			return default(bool);
		}

		public Vector3 GetCenterPos()
		{
			return default(Vector3);
		}

		public void AddHitFixedObject(CommonObjectStatus obj)
		{
		}

		private void AddRandomHitList(string additionalHitLabels, int addNum)
		{
		}
	}
}
