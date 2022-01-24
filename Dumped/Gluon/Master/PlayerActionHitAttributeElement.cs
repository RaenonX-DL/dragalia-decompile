using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class PlayerActionHitAttributeElement : IMasterElement
	{
		[SerializeField]
		private string _Id;

		[SerializeField]
		private string _FontEffect;

		[SerializeField]
		private ActionHitExecType _HitExecType;

		[SerializeField]
		private ActionTargetGroup _TargetGroup;

		[SerializeField]
		private Gluon.ElementalType _TargetElemental;

		[SerializeField]
		private Gluon.ElementalType _Elemental01;

		[SerializeField]
		private Gluon.ElementalType _Elemental02;

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
		private int _AttrIgnoreBarrier;

		[SerializeField]
		private int _AttrNoReaction;

		[SerializeField]
		private int _AttrShare;

		[SerializeField]
		private int _AttrCancelBind;

		[SerializeField]
		private int _AttrDragon;

		[SerializeField]
		private float _DamageAdjustment;

		[SerializeField]
		private float _ToOdDmgRate;

		[SerializeField]
		private float _ToBreakDmgRate;

		[SerializeField]
		private float _ToEightDownRate;

		[SerializeField]
		private float _AdditionCritical;

		[SerializeField]
		private string _AdditionalRandomHitLabel;

		[SerializeField]
		private int _AdditionalRandomHitNum;

		[SerializeField]
		private int _IsAdditionalAttackToEnemy;

		[SerializeField]
		private int _IsDamageMyself;

		[SerializeField]
		private float _SetCurrentHpRate;

		[SerializeField]
		private float _ConsumeHpRate;

		[SerializeField]
		private int _DamageSelfUpFromBuffCountBuffId;

		[SerializeField]
		private int _IsSubstitudeDamage;

		[SerializeField]
		private int _RecoveryValue;

		[SerializeField]
		private int _AdditionRecoverySp;

		[SerializeField]
		private float _RecoverySpRatio;

		[SerializeField]
		private int _RecoverySpSkillIndex;

		[SerializeField]
		private int _RecoverySpSkillIndex2;

		[SerializeField]
		private float _AdditionRecoveryDpPercentage;

		[SerializeField]
		private float _RecoveryDragonTime;

		[SerializeField]
		private int _AdditionRecoveryDpLv1;

		[SerializeField]
		private int _AdditionRecoveryDpAbility;

		[SerializeField]
		private int _RecoveryEp;

		[SerializeField]
		private int _RecoveryCP;

		[SerializeField]
		private int _RecoveryCPIndex;

		[SerializeField]
		private int _RecoveryCPEveryHit;

		[SerializeField]
		private int _AdditionActiveGaugeValue;

		[SerializeField]
		private int _AdditionRecoveryUtp;

		[SerializeField]
		private int _AddUtp;

		[SerializeField]
		private float _RecoveryAbsTime;

		[SerializeField]
		private float _RecoveryAbsCoolTime;

		[SerializeField]
		private int _RecoveryAbsFlags;

		[SerializeField]
		private int _IgnoreHitCountAddition;

		[SerializeField]
		private int _IgnoreFirstHitCheck;

		[SerializeField]
		private int _FixedDamage;

		[SerializeField]
		private int _CurrentHpRateDamage;

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
		private int _IsDisableHealSpOnCurse;

		[SerializeField]
		private int _ActionCondition1;

		[SerializeField]
		private string _HeadText;

		[SerializeField]
		private string _BattleLogText;

		[SerializeField]
		private int _ActionGrant;

		[SerializeField]
		private int _AuraId;

		[SerializeField]
		private int _AuraMaxLimitLevel;

		[SerializeField]
		private int _AuraTargetType;

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
		private int _KillerStateRelease;

		[SerializeField]
		private float _DamageUpRateByBuffCount;

		[SerializeField]
		private int _DamageUpDataByBuffCount;

		[SerializeField]
		private int _SplitDamageCount;

		[SerializeField]
		private int _SplitDamageCount2;

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
		private int _UseDamageMotionTimeScale;

		[SerializeField]
		private float _DamageMotionTimeScale;

		[SerializeField]
		private Gluon.PlayerHitCondition _HitConditionType;

		[SerializeField]
		private int _HitConditionP1;

		[SerializeField]
		private int _HitConditionP2;

		[SerializeField]
		private int _IsAddCombo;

		[SerializeField]
		private float _BlastHeight;

		[SerializeField]
		private float _BlastAngle;

		[SerializeField]
		private float _BlastGravity;

		public string Id => null;

		public string FontEffect => null;

		public ActionHitExecType HitExecType => default(ActionHitExecType);

		public ActionTargetGroup TargetGroup => default(ActionTargetGroup);

		public Gluon.ElementalType TargetElemental => default(Gluon.ElementalType);

		public Gluon.ElementalType Elemental01 => default(Gluon.ElementalType);

		public Gluon.ElementalType Elemental02 => default(Gluon.ElementalType);

		public int Attributes02 => default(int);

		public int Attributes03 => default(int);

		public LookToDamageType LookToDamageType => default(LookToDamageType);

		public int Attributes04 => default(int);

		public int Attributes05 => default(int);

		public int Attributes07 => default(int);

		public int Attributes08 => default(int);

		public int AttrIgnoreBarrier => default(int);

		public int AttrNoReaction => default(int);

		public int AttrShare => default(int);

		public int AttrCancelBind => default(int);

		public int AttrDragon => default(int);

		public float DamageAdjustment => default(float);

		public float ToOdDmgRate => default(float);

		public float ToBreakDmgRate => default(float);

		public float ToEightDownRate => default(float);

		public float AdditionCritical => default(float);

		public string AdditionalRandomHitLabel => null;

		public int AdditionalRandomHitNum => default(int);

		public int IsAdditionalAttackToEnemy => default(int);

		public int IsDamageMyself => default(int);

		public float SetCurrentHpRate => default(float);

		public float ConsumeHpRate => default(float);

		public int DamageSelfUpFromBuffCountBuffId => default(int);

		public int IsSubstitudeDamage => default(int);

		public int RecoveryValue => default(int);

		public int AdditionRecoverySp => default(int);

		public float RecoverySpRatio => default(float);

		public int RecoverySpSkillIndex => default(int);

		public int RecoverySpSkillIndex2 => default(int);

		public float AdditionRecoveryDpPercentage => default(float);

		public float RecoveryDragonTime => default(float);

		public int AdditionRecoveryDpLv1 => default(int);

		public int AdditionRecoveryDpAbility => default(int);

		public int RecoveryEp => default(int);

		public int RecoveryCP => default(int);

		public int RecoveryCPIndex => default(int);

		public int RecoveryCPEveryHit => default(int);

		public int AdditionActiveGaugeValue => default(int);

		public int AdditionRecoveryUtp => default(int);

		public int AddUtp => default(int);

		public float RecoveryAbsTime => default(float);

		public float RecoveryAbsCoolTime => default(float);

		public int RecoveryAbsFlags => default(int);

		public int IgnoreHitCountAddition => default(int);

		public int IgnoreFirstHitCheck => default(int);

		public int FixedDamage => default(int);

		public int CurrentHpRateDamage => default(int);

		public float HpDrainRate => default(float);

		public float HpDrainRate2 => default(float);

		public float HpDrainLimitRate => default(float);

		public string HpDrainAttribute => null;

		public float DamageCounterCoef => default(float);

		public float CrisisLimitRate => default(float);

		public float DamageDispDelaySec => default(float);

		public int IsDisableHealSpOnCurse => default(int);

		public int ActionCondition1 => default(int);

		public string HeadText => null;

		public string BattleLogText => null;

		public int ActionGrant => default(int);

		public int AuraId => default(int);

		public int AuraMaxLimitLevel => default(int);

		public int AuraTargetType => default(int);

		public int KillerState1 => default(int);

		public int KillerState2 => default(int);

		public int KillerState3 => default(int);

		public float KillerStateDamageRate => default(float);

		public string KillerStateDamageRateCurveDependsOnHitCount => null;

		public int KillerStateRelease => default(int);

		public float DamageUpRateByBuffCount => default(float);

		public int DamageUpDataByBuffCount => default(int);

		public int SplitDamageCount => default(int);

		public int SplitDamageCount2 => default(int);

		public int ArmorBreakLv => default(int);

		public int InvincibleBreakLv => default(int);

		public ActionKnockBackType KnockBackType => default(ActionKnockBackType);

		public float KnockBackDistance => default(float);

		public int KnockBackDependsOnMass => default(int);

		public float KnockBackDurationSec => default(float);

		public int UseDamageMotionTimeScale => default(int);

		public float DamageMotionTimeScale => default(float);

		public Gluon.PlayerHitCondition HitConditionType => default(Gluon.PlayerHitCondition);

		public int HitConditionP1 => default(int);

		public int HitConditionP2 => default(int);

		public int IsAddCombo => default(int);

		public float BlastHeight => default(float);

		public float BlastAngle => default(float);

		public float BlastGravity => default(float);
	}
}
