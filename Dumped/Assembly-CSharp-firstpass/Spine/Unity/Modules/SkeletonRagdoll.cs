/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using Spine.Unity;
using UnityEngine;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine.Unity.Modules
{
	[RequireComponent]
	public class SkeletonRagdoll : MonoBehaviour
	{
		// Fields
		private static Transform parentSpaceHelper;
		[Header]
		[SpineBone]
		public string startingBoneName;
		[SpineBone]
		public List<string> stopBoneNames;
		[Header]
		public bool applyOnStart;
		[Tooltip]
		public bool disableIK;
		public bool disableOtherConstraints;
		[Space]
		[Tooltip]
		public bool pinStartBone;
		[Tooltip]
		public bool enableJointCollision;
		public bool useGravity;
		[Tooltip]
		public float thickness;
		[Tooltip]
		public float rotationLimit;
		public float rootMass;
		[Range]
		[Tooltip]
		public float massFalloffFactor;
		[Tooltip]
		public int colliderLayer;
		[Range]
		public float mix;
		private ISkeletonAnimation targetSkeletonComponent;
		private Skeleton skeleton;
		private Dictionary<Bone, Transform> boneTable;
		private Transform ragdollRoot;
		[CompilerGenerated]
		private Rigidbody _RootRigidbody_k__BackingField;
		[CompilerGenerated]
		private Bone _StartingBone_k__BackingField;
		private Vector3 rootOffset;
		private bool isActive;
	
		// Properties
		public Rigidbody RootRigidbody { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Bone StartingBone { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Vector3 RootOffset { get; }
		public bool IsActive { get; }
		public Rigidbody[] RigidbodyArray { get; }
		public Vector3 EstimatedSkeletonPosition { get; }
	
		// Nested types
		public class LayerFieldAttribute : PropertyAttribute
		{
			// Constructors
			public LayerFieldAttribute();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__33 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SkeletonRagdoll __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__33(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _SmoothMixCoroutine_d__40 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SkeletonRagdoll __4__this;
			public float target;
			public float duration;
			private float _startTime_5__2;
			private float _startMix_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SmoothMixCoroutine_d__40(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public SkeletonRagdoll();
	
		// Methods
		[IteratorStateMachine]
		private IEnumerator Start();
		public void Apply();
		public Coroutine SmoothMix(float target, float duration);
		[IteratorStateMachine]
		private IEnumerator SmoothMixCoroutine(float target, float duration);
		public void SetSkeletonPosition(Vector3 worldPosition);
		public void Remove();
		public Rigidbody GetRigidbody(string boneName);
		private void RecursivelyCreateBoneProxies(Bone b);
		private void UpdateSpineSkeleton(ISkeletonAnimation skeletonRenderer);
		private List<Collider> AttachBoundingBoxRagdollColliders(Bone b);
		private static float GetPropagatedRotation(Bone b);
	}
}
