using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class CollisionTransform
	{
		public enum SlotFrontType
		{
			None,
			Follow,
			FollowY
		}

		public ActionCollisionPos _collisionPos;

		public Vector3 _ofsPos;

		public float _angle;

		public float _spaceLength;

		public SlotFrontType _slotFrontType;

		protected CharacterBase _owner;

		protected CharacterBase _attachChara;

		protected Vector3 _startPos;

		protected Vector3 _currentPos;

		protected Vector3 _prevPos;

		protected Vector3 _forward;

		protected Vector3 _startOwnerCenterPos;

		public Vector3 StartPos => default(Vector3);

		public Vector3 CurrentPos => default(Vector3);

		public Vector3 PrevPos => default(Vector3);

		public Vector3 Forward => default(Vector3);

		public Vector3 StartOwnerCenterPos => default(Vector3);

		protected float forwardOffsetLength
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

		protected bool isDefaultForwardOffset
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

		public virtual void Clear()
		{
		}

		public void Calc(CharacterBase owner, CharacterBase attachChara, [Optional] GameObject target, bool notUseOwnerForward = false)
		{
		}

		public void Calc(Vector3 startPos, Vector3 forward, [Optional] GameObject target)
		{
		}

		private void CalcStartTransform(Vector3 basePos, Vector3 forward, [Optional] GameObject target)
		{
		}

		private void CalcSlotTranfrom(string slotName)
		{
		}

		public void SetCurrentPosFromAdditionalAttack(Vector3 pos)
		{
		}
	}
}
