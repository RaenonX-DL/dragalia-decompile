/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public sealed class CollisionHitAttribute : CollisionTransform
	{
		// Fields
		public static readonly string debuffSelfDamage;
		public static readonly string timeStopDamage;
		public static readonly string brTouchHit;
		public const uint BR_EXCLUSION_ID = 549165420;
		[CompilerGenerated]
		private int _penetrateCount_k__BackingField;
		[CompilerGenerated]
		private float _attenuationRate_k__BackingField;
		[CompilerGenerated]
		private CharacterBase.HitProduction _exceptHitProduction_k__BackingField;
		[CompilerGenerated]
		private ICollideCallback _collideCallback_k__BackingField;
		[CompilerGenerated]
		private Action<int> _onHitCountAdded_k__BackingField;
		public int hitStopAcceptIndex;
		private CreateParam _createParam;
		public AdditionalAttackParam additionalAttackParam;
		[CompilerGenerated]
		private int _sameTimeHitId_k__BackingField;
		[CompilerGenerated]
		private bool _useSelfPosAsWallCheckOrigin_k__BackingField;
		[CompilerGenerated]
		private bool _useCustomWallCheckFromPos_k__BackingField;
		[CompilerGenerated]
		private Vector3 _customWallCheckFromPos_k__BackingField;
		[CompilerGenerated]
		private Dictionary<CharacterBase, DamageCalculation.DamageStatus> _fixedValueForCalc_k__BackingField;
		[CompilerGenerated]
		private bool _isQuestSkill_k__BackingField;
		[CompilerGenerated]
		private bool _enableApplyMultipleDebuff_k__BackingField;
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
		private float _DamageAdjustment;
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
		private bool _IsDamageMyself;
		[SerializeField]
		private float _SetCurrentHpRate;
		[SerializeField]
		private float _ConsumeHpRate;
		[SerializeField]
		private int _DamageSelfUpFromBuffCountBuffId;
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
		private int _KillerState1;
		[SerializeField]
		private int _KillerState2;
		[SerializeField]
		private int _KillerState3;
		[SerializeField]
		private float _KillerStateDamageRate;
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
		[CompilerGenerated]
		private float _hpDrainValue_k__BackingField;
		[CompilerGenerated]
		private float _hpDrainBuffValue_k__BackingField;
		[CompilerGenerated]
		private CharacterBase _hpDrainTarget_k__BackingField;
		[CompilerGenerated]
		private float _selfDamageHpRate_k__BackingField;
		[CompilerGenerated]
		private bool _isTimeStopDamage_k__BackingField;
		[CompilerGenerated]
		private ActionStartParameter _actionStartParam_k__BackingField;
		[CompilerGenerated]
		private bool _isCheckCollisionOnDefenceSide_k__BackingField;
		[CompilerGenerated]
		private uint _exclusionId_k__BackingField;
		[CompilerGenerated]
		private bool _isBuffDebuffFieldHit_k__BackingField;
		[CompilerGenerated]
		private bool _fromLinkAbility_k__BackingField;
		[CompilerGenerated]
		private List<CommonObjectStatus> _hitFixedObjects_k__BackingField;
		[CompilerGenerated]
		private bool _isFirstHitFinished_k__BackingField;
	
		// Properties
		public int penetrateCount { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float attenuationRate { [CompilerGenerated] get; [CompilerGenerated] set; }
		public CharacterBase.HitProduction exceptHitProduction { [CompilerGenerated] get; [CompilerGenerated] set; }
		public ICollideCallback collideCallback { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action<int> onHitCountAdded { [CompilerGenerated] get; [CompilerGenerated] set; }
		public CharacterBase Owner { get; }
		public CharacterBase CollisionAttachChara { get; }
		public InGameDef.CharacterType characterType { get; }
		public CharacterBase.HitType hitType { get; }
		public int actionId { get; }
		public int skillId { get; }
		public int bulletId { get; }
		public int actionProductId { get; }
		public int sameTimeHitId { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool useSelfPosAsWallCheckOrigin { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool useCustomWallCheckFromPos { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Vector3 customWallCheckFromPos { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Dictionary<CharacterBase, DamageCalculation.DamageStatus> fixedValueForCalc { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isQuestSkill { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool enableApplyMultipleDebuff { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool IsAbsorptionKnockBack { get; }
		public bool IsAbsorptionKnockBackByEnemyAbility { get; }
		public string Id { get; }
		public ActionHitExecType HitExecType { get; }
		public ActionTargetGroup HitTargetGroup { get; }
		public ElementalType HitTargetElemental { get; }
		public ElementalType Elemental01 { get; }
		public ElementalType Elemental02 { get; }
		public int Attributes02 { get; }
		public int Attributes03 { get; }
		public LookToDamageType LookToDamageType { get; }
		public int Attributes04 { get; }
		public int Attributes05 { get; }
		public int Attributes07 { get; }
		public int Attributes08 { get; }
		public int AttrOrderBarrer { get; }
		public int AttrIgnoreBarrier { get; }
		public int AttrNoReaction { get; }
		public float DamageAdjustment { get; set; }
		public float AbilityFactor { get; set; }
		public float ToOdDmgRate { get; }
		public float ToBreakDmgRate { get; }
		public float ToEightDownRate { get; }
		public float AdditionCritical { get; }
		public bool IsDamageMyself { get; }
		public float SetCurrentHpRate { get; }
		public float ConsumeHpRate { get; }
		public int DamageSelfUpFromBuffCountBuffId { get; }
		public int RecoveryValue { get; }
		public int AdditionRecoverySp { get; }
		public float RecoverySpRatio { get; }
		public int RecoverySpSkillIndex { get; }
		public int AdditionRecoveryDp { get; }
		public int AdditionRecoveryDpAbility { get; }
		public float AdditionRecoveryDpPercentage { get; }
		public float RecoveryDragonTime { get; }
		public int RecoveryEp { get; }
		public int RecoveryCP { get; }
		public int RecoveryCPIndex { get; }
		public int RecoveryCPEveryHit { get; }
		public int AdditionRecoveryUtp { get; }
		public int AddUtp { get; }
		public bool IgnoreHitCountAddition { get; }
		public bool IgnoreFirstHitCheck { get; }
		public float HpDrainRate { get; }
		public float HpDrainRate2 { get; }
		public float HpDrainLimitRate { get; set; }
		public string HpDrainAttribute { get; }
		public float DamageCounterCoef { get; }
		public float CrisisLimitRate { get; }
		public float DamageDispDelaySec { get; set; }
		public bool IsDisableHealSpOnCurse { get; }
		public string HeadText { get; }
		public string BattleLogText { get; }
		public int SplitDamageCount { get; }
		public int SplitDamageCount2 { get; }
		public int ActionCondition { get; }
		public int ActionGrant { get; }
		public int KillerState1 { get; }
		public int KillerState2 { get; }
		public int KillerState3 { get; }
		public float KillerStateDamageRate { get; }
		public float KillerStateRelease { get; }
		public float DamageUpRateByBuffCount { get; }
		public int DamageUpDataByBuffCount { get; }
		public int ArmorBreakLv { get; }
		public int InvincibleBreakLv { get; set; }
		public ActionKnockBackType KnockBackType { get; }
		public float KnockBackDistance { get; }
		public int KnockBackDependsOnMass { get; }
		public float KnockBackDurationSec { get; }
		public float BlastHeight { get; }
		public float BlastAngle { get; }
		public float BlastGravity { get; }
		public ActionCollision Collision { get; set; }
		public float CollisionLength { get; set; }
		public float CollisionFan { get; set; }
		public float CollisionAngle { get; set; }
		public float CollisionWidth { get; set; }
		public float CollisionHeight { get; set; }
		public string FontEffect { get; }
		public int FollowerAvoidProbability { get; }
		public FollowerAvoidType FollowerAvoidType { get; }
		public bool UseDamageMotionTimeScale { get; }
		public float DamageMotionTimeScale { get; }
		public bool IsShare { get; }
		public bool IsCancelTransform { get; }
		public bool IsCancelBind { get; }
		public int CurrentHpRateDamage { get; }
		public int MaxHpRateDamage { get; }
		public bool IsKillHpRateDamage { get; }
		public int AdditionActiveGaugeValue { get; }
		public bool IsAddElectrify { get; }
		public PlayerHitCondition HitConditionType { get; }
		public int HitConditionP1 { get; }
		public int HitConditionP2 { get; }
		public bool IsAddCombo { get; }
		public bool IsAdditionalAttackToEnemy { get; set; }
		public int FixedDamage { get; set; }
		public float hpDrainValue { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float hpDrainBuffValue { [CompilerGenerated] get; [CompilerGenerated] set; }
		public CharacterBase hpDrainTarget { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float selfDamageHpRate { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isTimeStopDamage { [CompilerGenerated] get; [CompilerGenerated] set; }
		public ActionStartParameter actionStartParam { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isCheckCollisionOnDefenceSide { [CompilerGenerated] get; [CompilerGenerated] set; }
		public uint exclusionId { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isBuffDebuffFieldHit { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool fromLinkAbility { [CompilerGenerated] get; [CompilerGenerated] set; }
		public List<CommonObjectStatus> hitFixedObjects { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isFirstHitFinished { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public struct CreateParam
		{
			// Fields
			public InGameDef.CharacterType characterType;
			public int elementIndex;
			public int actionId;
			public int skillId;
			public int bulletId;
			public int productId;
	
			// Methods
			public void Setup(InGameDef.CharacterType characterType, int elementIndex, int actionId, int skillId, int bulletId, int productId);
		}
	
		public struct AdditionalAttackParam
		{
			// Fields
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
	
		// Constructors
		public CollisionHitAttribute();
		static CollisionHitAttribute();
	
		// Methods
		public CreateParam GetCreateParam();
		public void SetOwner(CharacterBase owner);
		private void ResetHpDrain();
		public override void Clear();
		public static CollisionHitAttribute FromPlayActionHitAttribute(int actionId, int skillId, int bulletId, int productId, string elementId);
		public void Startup(int actionId, int skillId, int bulletId, int productId, Tuple<int, PlayerActionHitAttributeElement> pair);
		public static CollisionHitAttribute FromEnemyActionHitAttribute(int actionId, int bulletId, int productId, string elementId);
		public void Startup(int actionId, int bulletId, int productId, Tuple<int, EnemyActionHitAttributeElement> pair);
		public static CollisionHitAttribute FromCommonActionHitAttribute(int actionId, int bulletId, string elementId);
		public void Startup(int actionId, int bulletId, Tuple<int, CommonActionHitAttributeElement> pair);
		public static bool Create(CreateParam param, ref CollisionHitAttribute outResult);
		public void Init(CharacterBase owner, CharacterBase attachChara = null, GameObject target = null);
		public void Init(CharacterBase owner, Vector3 startPos, Vector3 forward, CharacterBase attachChara = null, GameObject target = null);
		public void Init(Vector3 startPos, Vector3 forward);
		public void SetTransfrom(Vector3 pos, Vector3 forward, bool resetPrevPos = false);
		public void CalcTransform(Vector3 pos, Vector3 forward);
		public void SetForwardOffset(float length);
		public bool NeedSyncHit();
		public bool IsCheckCollisionOnDefenceSide();
		public bool IsDamageTransform();
		public Vector3 GetCenterPos();
		public void AddHitFixedObject(CommonObjectStatus obj);
	}
}
