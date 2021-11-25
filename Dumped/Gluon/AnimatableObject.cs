using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class AnimatableObject : RenderObjectBase
	{
		public Animator animator;

		public GameObject weapon;

		private CharacterBase owner;

		private Vector3 position;

		private Quaternion rotation;

		public GameObject parentGameObject;

		private EffectObject.FollowPosType _followPosType;

		private EffectObject.FollowRotType _followRotType;

		public bool isUsed
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

		public void SetOwner(CharacterBase value)
		{
		}

		public virtual void Initialize()
		{
		}

		protected override void OnEnable()
		{
		}

		public override void LateUpdate()
		{
		}

		public void Generate()
		{
		}

		public void Destroy()
		{
		}

		public void SetWeaponVisibility(bool visible)
		{
		}

		public void SetLocalPosition(Vector3 localPosition)
		{
		}

		public void SetLocalRotation(Quaternion localRotation)
		{
		}

		public void SetParent(GameObject parent)
		{
		}

		public void SetDefaultFollowType()
		{
		}

		public void SetFollowType(EffectObject.FollowPosType posType, EffectObject.FollowRotType rotType)
		{
		}

		public void SetFollowPositionType(EffectObject.FollowPosType posType)
		{
		}

		public void SetFollowRotationType(EffectObject.FollowRotType rotType)
		{
		}

		public void UpdatePose()
		{
		}
	}
}
