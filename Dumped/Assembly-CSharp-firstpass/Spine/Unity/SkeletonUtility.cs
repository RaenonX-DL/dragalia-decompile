/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using UnityEngine;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine.Unity
{
	[ExecuteInEditMode]
	[RequireComponent]
	public class SkeletonUtility : MonoBehaviour
	{
		// Fields
		[CompilerGenerated]
		private SkeletonUtilityDelegate OnReset;
		public Transform boneRoot;
		[HideInInspector]
		public SkeletonRenderer skeletonRenderer;
		[HideInInspector]
		public ISkeletonAnimation skeletonAnimation;
		[NonSerialized]
		public List<SkeletonUtilityBone> utilityBones;
		[NonSerialized]
		public List<SkeletonUtilityConstraint> utilityConstraints;
		protected bool hasTransformBones;
		protected bool hasUtilityConstraints;
		protected bool needToReprocessBones;
	
		// Events
		public event SkeletonUtilityDelegate OnReset {
			add;
			remove;
		}
	
		// Nested types
		public delegate void SkeletonUtilityDelegate();
	
		// Constructors
		public SkeletonUtility();
	
		// Methods
		public static PolygonCollider2D AddBoundingBoxGameObject(Skeleton skeleton, string skinName, string slotName, string attachmentName, Transform parent, bool isTrigger = true);
		public static PolygonCollider2D AddBoundingBoxGameObject(string name, BoundingBoxAttachment box, Slot slot, Transform parent, bool isTrigger = true);
		public static PolygonCollider2D AddBoundingBoxAsComponent(BoundingBoxAttachment box, Slot slot, GameObject gameObject, bool isTrigger = true, bool isKinematic = true, float gravityScale = 0f);
		public static void SetColliderPointsLocal(PolygonCollider2D collider, Slot slot, BoundingBoxAttachment box);
		public static Bounds GetBoundingBoxBounds(BoundingBoxAttachment boundingBox, float depth = 0f);
		private void Update();
		private void OnEnable();
		private void Start();
		private void OnDisable();
		private void HandleRendererReset(SkeletonRenderer r);
		public void RegisterBone(SkeletonUtilityBone bone);
		public void UnregisterBone(SkeletonUtilityBone bone);
		public void RegisterConstraint(SkeletonUtilityConstraint constraint);
		public void UnregisterConstraint(SkeletonUtilityConstraint constraint);
		public void CollectBones();
		private void UpdateLocal(ISkeletonAnimation anim);
		private void UpdateWorld(ISkeletonAnimation anim);
		private void UpdateComplete(ISkeletonAnimation anim);
		private void UpdateAllBones(SkeletonUtilityBone.UpdatePhase phase);
		public Transform GetBoneRoot();
		public GameObject SpawnRoot(SkeletonUtilityBone.Mode mode, bool pos, bool rot, bool sca);
		public GameObject SpawnHierarchy(SkeletonUtilityBone.Mode mode, bool pos, bool rot, bool sca);
		public GameObject SpawnBoneRecursively(Bone bone, Transform parent, SkeletonUtilityBone.Mode mode, bool pos, bool rot, bool sca);
		public GameObject SpawnBone(Bone bone, Transform parent, SkeletonUtilityBone.Mode mode, bool pos, bool rot, bool sca);
	}
}
