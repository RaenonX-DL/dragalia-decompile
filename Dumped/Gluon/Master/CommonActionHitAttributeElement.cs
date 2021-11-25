using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class CommonActionHitAttributeElement : IMasterElement
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
		private Gluon.ActionCollision _Collision;

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

		public int AttrNoReaction => default(int);

		public float DamageAdjustment => default(float);

		public int SplitDamageCount => default(int);

		public int RecoveryValue => default(int);

		public int ActionCondition => default(int);

		public int BlastLv => default(int);

		public int ArmorBreakLv => default(int);

		public int InvincibleBreakLv => default(int);

		public ActionKnockBackType KnockBackType => default(ActionKnockBackType);

		public float KnockBackDistance => default(float);

		public int KnockBackDependsOnMass => default(int);

		public float KnockBackDurationSec => default(float);

		public float BlastHeight => default(float);

		public float BlastAngle => default(float);

		public float BlastGravity => default(float);

		public Gluon.ActionCollision Collision => default(Gluon.ActionCollision);

		public ActionCollisionPos CollisionPosId => default(ActionCollisionPos);

		public int IsCollisionSlotFront => default(int);

		public float CollisionOffsetX => default(float);

		public float CollisionOffsetY => default(float);

		public float CollisionOffsetZ => default(float);

		public float CollisionLength => default(float);

		public float CollisionFan => default(float);

		public float CollisionAngle => default(float);

		public float CollisionWidth => default(float);

		public float CollisionHeight => default(float);

		public int FollowerAvoidProbability => default(int);

		public FollowerAvoidType FollowerAvoidType => default(FollowerAvoidType);
	}
}
