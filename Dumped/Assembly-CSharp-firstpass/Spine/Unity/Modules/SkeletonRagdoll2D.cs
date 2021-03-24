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

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine.Unity.Modules
{
	[RequireComponent]
	public class SkeletonRagdoll2D : MonoBehaviour
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
		public float gravityScale;
		[Tooltip]
		public float thickness;
		[Tooltip]
		public float rotationLimit;
		public float rootMass;
		[Range]
		[Tooltip]
		public float massFalloffFactor;
		[SkeletonRagdoll.LayerField]
		[Tooltip]
		public int colliderLayer;
		[Range]
		public float mix;
		private ISkeletonAnimation targetSkeletonComponent;
		private Skeleton skeleton;
		private Dictionary<Bone, Transform> boneTable;
		private Transform ragdollRoot;
		[CompilerGenerated]
		private Rigidbody2D _RootRigidbody_k__BackingField;
		[CompilerGenerated]
		private Bone _StartingBone_k__BackingField;
		private Vector2 rootOffset;
		private bool isActive;
	
		// Properties
		public Rigidbody2D RootRigidbody { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Bone StartingBone { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Vector3 RootOffset { get; }
		public bool IsActive { get; }
		public Rigidbody2D[] RigidbodyArray { get; }
		public Vector3 EstimatedSkeletonPosition { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Start_d__32 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SkeletonRagdoll2D __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__32(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _SmoothMixCoroutine_d__39 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SkeletonRagdoll2D __4__this;
			public float target;
			public float duration;
			private float _startTime_5__2;
			private float _startMix_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SmoothMixCoroutine_d__39(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public SkeletonRagdoll2D();
	
		// Methods
		[IteratorStateMachine]
		private IEnumerator Start();
		public void Apply();
		public Coroutine SmoothMix(float target, float duration);
		[IteratorStateMachine]
		private IEnumerator SmoothMixCoroutine(float target, float duration);
		public void SetSkeletonPosition(Vector3 worldPosition);
		public void Remove();
		public Rigidbody2D GetRigidbody(string boneName);
		private void RecursivelyCreateBoneProxies(Bone b);
		private void UpdateSpineSkeleton(ISkeletonAnimation animatedSkeleton);
		private static List<Collider2D> AttachBoundingBoxRagdollColliders(Bone b, GameObject go, Skeleton skeleton, float gravityScale);
		private static float GetPropagatedRotation(Bone b);
		private static Vector3 FlipScale(bool flipX, bool flipY);
	}
}
