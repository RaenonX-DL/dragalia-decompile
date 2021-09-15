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
	public class EnemyActionHitAttributeElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private string _Id;
		[SerializeField]
		private ActionHitExecType _HitExecType;
		[SerializeField]
		private ActionTargetGroup _TargetGroup;
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
	
		// Properties
		public string Id { get; }
		public ActionHitExecType HitExecType { get; }
		public ActionTargetGroup TargetGroup { get; }
		public ElementalType Elemental01 { get; }
		public ElementalType Elemental02 { get; }
		public int Attributes02 { get; }
		public int Attributes03 { get; }
		public LookToDamageType LookToDamageType { get; }
		public int Attributes04 { get; }
		public int Attributes05 { get; }
		public int Attributes07 { get; }
		public int Attributes08 { get; }
		public int AttrOrderBarrier { get; }
		public int AttrNoReaction { get; }
		public int AttrShare { get; }
		public int AttrCancelTransform { get; }
		public int AttrCancelBind { get; }
		public int AttrPenetrateShield { get; }
		public int AttrDisallowRecovery { get; }
		public float DamageAdjustment { get; }
		public float AbilityFactor { get; }
		public int FixedDamage { get; }
		public int CurrentHpRateDamage { get; }
		public int MaxHpRateDamage { get; }
		public int IsKillHpRateDamage { get; }
		public float HpDrainRate2 { get; }
		public float HpDrainLimitRate { get; }
		public string HpDrainAttribute { get; }
		public int SplitDamageCount { get; }
		public int ActionCondition { get; }
		public int BlastLv { get; }
		public int ArmorBreakLv { get; }
		public int InvincibleBreakLv { get; }
		public ActionKnockBackType KnockBackType { get; }
		public float KnockBackDistance { get; }
		public float KnockBackDurationSec { get; }
		public int UseDamageMotionTimeScale { get; }
		public float DamageMotionTimeScale { get; }
		public float BlastHeight { get; }
		public float BlastAngle { get; }
		public float BlastGravity { get; }
		public int FollowerAvoidProbability { get; }
		public FollowerAvoidType FollowerAvoidType { get; }
		public int IsAddElectrify { get; }
		public int OdCounterType { get; }
		public int OdCounterBonus { get; }
		public int CutDpRate { get; }
		public int CutUtpRate { get; }
		public int ParticularTargetId { get; }
	
		// Constructors
		public EnemyActionHitAttributeElement();
	}
}
