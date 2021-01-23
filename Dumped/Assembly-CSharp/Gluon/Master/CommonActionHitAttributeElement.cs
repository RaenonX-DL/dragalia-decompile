/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class CommonActionHitAttributeElement : IMasterElement
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
		private int _AttrNoReaction;
		[SerializeField]
		private float _DamageAdjustment;
		[SerializeField]
		private int _SplitDamageCount;
		[SerializeField]
		private int _RecoveryValue;
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
		private ActionCollisionPos _CollisionPosId;
		[SerializeField]
		private int _IsCollisionSlotFront;
		[SerializeField]
		private float _CollisionOffsetX;
		[SerializeField]
		private float _CollisionOffsetY;
		[SerializeField]
		private float _CollisionOffsetZ;
		[SerializeField]
		private float _CollisionLength;
		[SerializeField]
		private float _CollisionFan;
		[SerializeField]
		private float _CollisionAngle;
		[SerializeField]
		private float _CollisionWidth;
		[SerializeField]
		private float _CollisionHeight;
		[SerializeField]
		private int _FollowerAvoidProbability;
		[SerializeField]
		private FollowerAvoidType _FollowerAvoidType;
	
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
		public int AttrNoReaction { get; }
		public float DamageAdjustment { get; }
		public int SplitDamageCount { get; }
		public int RecoveryValue { get; }
		public int ActionCondition { get; }
		public int BlastLv { get; }
		public int ArmorBreakLv { get; }
		public int InvincibleBreakLv { get; }
		public ActionKnockBackType KnockBackType { get; }
		public float KnockBackDistance { get; }
		public int KnockBackDependsOnMass { get; }
		public float KnockBackDurationSec { get; }
		public float BlastHeight { get; }
		public float BlastAngle { get; }
		public float BlastGravity { get; }
		public ActionCollision Collision { get; }
		public ActionCollisionPos CollisionPosId { get; }
		public int IsCollisionSlotFront { get; }
		public float CollisionOffsetX { get; }
		public float CollisionOffsetY { get; }
		public float CollisionOffsetZ { get; }
		public float CollisionLength { get; }
		public float CollisionFan { get; }
		public float CollisionAngle { get; }
		public float CollisionWidth { get; }
		public float CollisionHeight { get; }
		public int FollowerAvoidProbability { get; }
		public FollowerAvoidType FollowerAvoidType { get; }
	
		// Constructors
		public CommonActionHitAttributeElement();
	}
}
