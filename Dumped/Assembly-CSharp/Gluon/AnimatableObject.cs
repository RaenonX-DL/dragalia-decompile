/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AnimatableObject : RenderObjectBase
	{
		// Fields
		[CompilerGenerated]
		private bool _isUsed_k__BackingField;
		public Animator animator;
		public GameObject weapon;
		private CharacterBase owner;
		private Vector3 position;
		private Quaternion rotation;
		public GameObject parentGameObject;
		private EffectObject.FollowPosType _followPosType;
		private EffectObject.FollowRotType _followRotType;
	
		// Properties
		public bool isUsed { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public AnimatableObject();
	
		// Methods
		public void SetOwner(CharacterBase value);
		public virtual void Initialize();
		protected override void OnEnable();
		public override void LateUpdate();
		public void Generate();
		public void Destroy();
		public void SetWeaponVisibility(bool visible);
		public void SetLocalPosition(Vector3 localPosition);
		public void SetLocalRotation(Quaternion localRotation);
		public void SetParent(GameObject parent);
		public void SetDefaultFollowType();
		public void SetFollowType(EffectObject.FollowPosType posType, EffectObject.FollowRotType rotType);
		public void SetFollowPositionType(EffectObject.FollowPosType posType);
		public void SetFollowRotationType(EffectObject.FollowRotType rotType);
		public void UpdatePose();
	}
}
