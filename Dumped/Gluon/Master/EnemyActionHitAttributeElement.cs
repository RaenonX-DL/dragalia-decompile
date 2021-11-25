using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class EnemyActionHitAttributeElement : IMasterElement
	{
		[SerializeField]
		private string _Id;

		[SerializeField]
		private ActionHitExecType _HitExecType;

		[SerializeField]
		private ActionTargetGroup _TargetGroup;

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
		private int _AttrOrderBarrier;

		[SerializeField]
		private int _AttrNoReaction;

		[SerializeField]
		private int _AttrShare;

		[SerializeField]
		private int _AttrCancelTransform;

		[SerializeField]
		private int _AttrCancelBind;

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
		private int _FixedDamage;

		[SerializeField]
		private int _CurrentHpRateDamage;

		[SerializeField]
		private int _MaxHpRateDamage;

		[SerializeField]
		private int _IsKillHpRateDamage;

		[SerializeField]
		private float _HpDrainRate2;

		[SerializeField]
		private float _HpDrainLimitRate;

		[SerializeField]
		private string _HpDrainAttribute;

		[SerializeField]
		private int _SplitDamageCount;

		[SerializeField]
		private int _ActionCondition;

		[SerializeField]
		private int _BlastLv;

		[SerializeField]
		private int _ArmorBreakLv;

		[SerializeField]
		private int _InvincibleBreakLv;

		[SerializeField]
		private ActionKnockBackType _KnockBackType;

		[SerializeField]
		private float _KnockBackDistance;

		[SerializeField]
		private float _KnockBackDurationSec;

		[SerializeField]
		private int _UseDamageMotionTimeScale;

		[SerializeField]
		private float _DamageMotionTimeScale;

		[SerializeField]
		private float _BlastHeight;

		[SerializeField]
		private float _BlastAngle;

		[SerializeField]
		private float _BlastGravity;

		[SerializeField]
		private int _FollowerAvoidProbability;

		[SerializeField]
		private FollowerAvoidType _FollowerAvoidType;

		[SerializeField]
		private int _IsAddElectrify;

		[SerializeField]
		private int _OdCounterType;

		[SerializeField]
		private int _OdCounterBonus;

		[SerializeField]
		private int _CutDpRate;

		[SerializeField]
		private int _CutUtpRate;

		[SerializeField]
		private int _ParticularTargetId;

		public string Id => null;

		public ActionHitExecType HitExecType => default(ActionHitExecType);

		public ActionTargetGroup TargetGroup => default(ActionTargetGroup);

		public Gluon.ElementalType Elemental01 => default(Gluon.ElementalType);

		public Gluon.ElementalType Elemental02 => default(Gluon.ElementalType);

		public int Attributes02 => default(int);

		public int Attributes03 => default(int);

		public LookToDamageType LookToDamageType => default(LookToDamageType);

		public int Attributes04 => default(int);

		public int Attributes05 => default(int);

		public int Attributes07 => default(int);

		public int Attributes08 => default(int);

		public int AttrOrderBarrier => default(int);

		public int AttrNoReaction => default(int);

		public int AttrShare => default(int);

		public int AttrCancelTransform => default(int);

		public int AttrCancelBind => default(int);

		public int AttrPenetrateShield => default(int);

		public int AttrDisallowRecovery => default(int);

		public float DamageAdjustment => default(float);

		public float DamageAdjustmentForFollower => default(float);

		public float AbilityFactor => default(float);

		public int FixedDamage => default(int);

		public int CurrentHpRateDamage => default(int);

		public int MaxHpRateDamage => default(int);

		public int IsKillHpRateDamage => default(int);

		public float HpDrainRate2 => default(float);

		public float HpDrainLimitRate => default(float);

		public string HpDrainAttribute => null;

		public int SplitDamageCount => default(int);

		public int ActionCondition => default(int);

		public int BlastLv => default(int);

		public int ArmorBreakLv => default(int);

		public int InvincibleBreakLv => default(int);

		public ActionKnockBackType KnockBackType => default(ActionKnockBackType);

		public float KnockBackDistance => default(float);

		public float KnockBackDurationSec => default(float);

		public int UseDamageMotionTimeScale => default(int);

		public float DamageMotionTimeScale => default(float);

		public float BlastHeight => default(float);

		public float BlastAngle => default(float);

		public float BlastGravity => default(float);

		public int FollowerAvoidProbability => default(int);

		public FollowerAvoidType FollowerAvoidType => default(FollowerAvoidType);

		public int IsAddElectrify => default(int);

		public int OdCounterType => default(int);

		public int OdCounterBonus => default(int);

		public int CutDpRate => default(int);

		public int CutUtpRate => default(int);

		public int ParticularTargetId => default(int);
	}
}
