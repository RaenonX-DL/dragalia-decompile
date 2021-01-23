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
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class BoneFollowerGraphic : MonoBehaviour
	{
		// Fields
		public SkeletonGraphic skeletonGraphic;
		public bool initializeOnAwake;
		[SerializeField]
		[SpineBone]
		public string boneName;
		public bool followBoneRotation;
		[Tooltip]
		public bool followSkeletonFlip;
		[Tooltip]
		public bool followLocalScale;
		public bool followZPosition;
		[NonSerialized]
		public Bone bone;
		private Transform skeletonTransform;
		private bool skeletonTransformIsParent;
		[NonSerialized]
		public bool valid;
	
		// Properties
		public SkeletonGraphic SkeletonGraphic { get; set; }
	
		// Constructors
		public BoneFollowerGraphic();
	
		// Methods
		public bool SetBone(string name);
		public void Awake();
		public void Initialize();
		public void LateUpdate();
	}
}
