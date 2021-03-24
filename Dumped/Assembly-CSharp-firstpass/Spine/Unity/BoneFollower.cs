/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using UnityEngine;
using UnityEngine.Serialization;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine.Unity
{
	[AddComponentMenu]
	[ExecuteInEditMode]
	public class BoneFollower : MonoBehaviour
	{
		// Fields
		public SkeletonRenderer skeletonRenderer;
		[SerializeField]
		[SpineBone]
		public string boneName;
		public bool followZPosition;
		public bool followBoneRotation;
		[Tooltip]
		public bool followSkeletonFlip;
		[Tooltip]
		public bool followLocalScale;
		[FormerlySerializedAs]
		public bool initializeOnAwake;
		[NonSerialized]
		public bool valid;
		[NonSerialized]
		public Bone bone;
		private Transform skeletonTransform;
		private bool skeletonTransformIsParent;
	
		// Properties
		public SkeletonRenderer SkeletonRenderer { get; set; }
	
		// Constructors
		public BoneFollower();
	
		// Methods
		public bool SetBone(string name);
		public void Awake();
		public void HandleRebuildRenderer(SkeletonRenderer skeletonRenderer);
		public void Initialize();
		private void OnDestroy();
		public void LateUpdate();
	}
}
