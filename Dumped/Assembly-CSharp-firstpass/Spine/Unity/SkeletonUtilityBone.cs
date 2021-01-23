/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using UnityEngine;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine.Unity
{
	[AddComponentMenu]
	[ExecuteInEditMode]
	public class SkeletonUtilityBone : MonoBehaviour
	{
		// Fields
		public string boneName;
		public Transform parentReference;
		public Mode mode;
		public bool position;
		public bool rotation;
		public bool scale;
		public bool zPosition;
		[Range]
		public float overrideAlpha;
		[NonSerialized]
		public SkeletonUtility skeletonUtility;
		[NonSerialized]
		public Bone bone;
		[NonSerialized]
		public bool transformLerpComplete;
		[NonSerialized]
		public bool valid;
		private Transform cachedTransform;
		private Transform skeletonTransform;
		private bool incompatibleTransformMode;
	
		// Properties
		public bool IncompatibleTransformMode { get; }
	
		// Nested types
		public enum Mode
		{
			Follow = 0,
			Override = 1
		}
	
		public enum UpdatePhase
		{
			Local = 0,
			World = 1,
			Complete = 2
		}
	
		// Constructors
		public SkeletonUtilityBone();
	
		// Methods
		public void Reset();
		private void OnEnable();
		private void HandleOnReset();
		private void OnDisable();
		public void DoUpdate(UpdatePhase phase);
		public static bool BoneTransformModeIncompatible(Bone bone);
		public void AddBoundingBox(string skinName, string slotName, string attachmentName);
	}
}
