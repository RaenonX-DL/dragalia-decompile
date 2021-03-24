/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using UnityEngine;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine.Unity
{
	[AddComponentMenu]
	[ExecuteInEditMode]
	public class PointFollower : MonoBehaviour, IHasSkeletonRenderer, IHasSkeletonComponent
	{
		// Fields
		[SerializeField]
		public SkeletonRenderer skeletonRenderer;
		[SpineSlot]
		public string slotName;
		[SpineAttachment]
		public string pointAttachmentName;
		public bool followRotation;
		public bool followSkeletonFlip;
		public bool followSkeletonZPosition;
		private Transform skeletonTransform;
		private bool skeletonTransformIsParent;
		private PointAttachment point;
		private Bone bone;
		private bool valid;
	
		// Properties
		public SkeletonRenderer SkeletonRenderer { get; }
		public ISkeletonComponent SkeletonComponent { get; }
		public bool IsValid { get; }
	
		// Constructors
		public PointFollower();
	
		// Methods
		public void Initialize();
		private void HandleRebuildRenderer(SkeletonRenderer skeletonRenderer);
		private void UpdateReferences();
		public void LateUpdate();
	}
}
