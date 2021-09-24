/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class PlayerActionHitAttributeElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private string _Id;
		[SerializeField]
		private string _FontEffect;
		[SerializeField]
		private ActionHitExecType _HitExecType;
		[SerializeField]
		private ActionTargetGroup _TargetGroup;
		[SerializeField]
		private ElementalType _TargetElemental;
		[SerializeField]
		private ElementalType _Elemental01;
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
		private PlayerHitCondition _HitConditionType;
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
	
		// Properties
		public string Id { get; }
		public string FontEffect { get; }
		public ActionHitExecType HitExecType { get; }
		public ActionTargetGroup TargetGroup { get; }
		public ElementalType TargetElemental { get; }
		public ElementalType Elemental01 { get; }
		public ElementalType Elemental02 { get; }
		public int Attributes02 { get; }
		public int Attributes03 { get; }
		public LookToDamageType LookToDamageType { get; }
		public int Attributes04 { get; }
		public int Attributes05 { get; }
		public int Attributes07 { get; }
		public int Attributes08 { get; }
		public int AttrIgnoreBarrier { get; }
		public int AttrNoReaction { get; }
		public int AttrShare { get; }
		public int AttrCancelBind { get; }
		public int AttrDragon { get; }
		public float DamageAdjustment { get; }
		public float ToOdDmgRate { get; }
		public float ToBreakDmgRate { get; }
		public float ToEightDownRate { get; }
		public float AdditionCritical { get; }
		public string AdditionalRandomHitLabel { get; }
		public int AdditionalRandomHitNum { get; }
		public int IsAdditionalAttackToEnemy { get; }
		public int IsDamageMyself { get; }
		public float SetCurrentHpRate { get; }
		public float ConsumeHpRate { get; }
		public int DamageSelfUpFromBuffCountBuffId { get; }
		public int IsSubstitudeDamage { get; }
		public int RecoveryValue { get; }
		public int AdditionRecoverySp { get; }
		public float RecoverySpRatio { get; }
		public int RecoverySpSkillIndex { get; }
		public int RecoverySpSkillIndex2 { get; }
		public float AdditionRecoveryDpPercentage { get; }
		public float RecoveryDragonTime { get; }
		public int AdditionRecoveryDpLv1 { get; }
		public int AdditionRecoveryDpAbility { get; }
		public int RecoveryEp { get; }
		public int RecoveryCP { get; }
		public int RecoveryCPIndex { get; }
		public int RecoveryCPEveryHit { get; }
		public int AdditionActiveGaugeValue { get; }
		public int AdditionRecoveryUtp { get; }
		public int AddUtp { get; }
		public int IgnoreHitCountAddition { get; }
		public int IgnoreFirstHitCheck { get; }
		public int FixedDamage { get; }
		public int CurrentHpRateDamage { get; }
		public float HpDrainRate { get; }
		public float HpDrainRate2 { get; }
		public float HpDrainLimitRate { get; }
		public string HpDrainAttribute { get; }
		public float DamageCounterCoef { get; }
		public float CrisisLimitRate { get; }
		public float DamageDispDelaySec { get; }
		public int IsDisableHealSpOnCurse { get; }
		public int ActionCondition1 { get; }
		public string HeadText { get; }
		public string BattleLogText { get; }
		public int ActionGrant { get; }
		public int AuraId { get; }
		public int AuraMaxLimitLevel { get; }
		public int AuraTargetType { get; }
		public int KillerState1 { get; }
		public int KillerState2 { get; }
		public int KillerState3 { get; }
		public float KillerStateDamageRate { get; }
		public string KillerStateDamageRateCurveDependsOnHitCount { get; }
		public int KillerStateRelease { get; }
		public float DamageUpRateByBuffCount { get; }
		public int DamageUpDataByBuffCount { get; }
		public int SplitDamageCount { get; }
		public int SplitDamageCount2 { get; }
		public int ArmorBreakLv { get; }
		public int InvincibleBreakLv { get; }
		public ActionKnockBackType KnockBackType { get; }
		public float KnockBackDistance { get; }
		public int KnockBackDependsOnMass { get; }
		public float KnockBackDurationSec { get; }
		public int UseDamageMotionTimeScale { get; }
		public float DamageMotionTimeScale { get; }
		public PlayerHitCondition HitConditionType { get; }
		public int HitConditionP1 { get; }
		public int HitConditionP2 { get; }
		public int IsAddCombo { get; }
		public float BlastHeight { get; }
		public float BlastAngle { get; }
		public float BlastGravity { get; }
	
		// Constructors
		public PlayerActionHitAttributeElement();
	}
}
