/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using UnityEngine;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine.Unity
{
	[ExecuteInEditMode]
	public class BoundingBoxFollower : MonoBehaviour
	{
		// Fields
		internal static bool DebugMessages;
		public SkeletonRenderer skeletonRenderer;
		[SpineSlot]
		public string slotName;
		public bool isTrigger;
		public bool clearStateOnDisable;
		private Slot slot;
		private BoundingBoxAttachment currentAttachment;
		private string currentAttachmentName;
		private PolygonCollider2D currentCollider;
		public readonly Dictionary<BoundingBoxAttachment, PolygonCollider2D> colliderTable;
		public readonly Dictionary<BoundingBoxAttachment, string> nameTable;
	
		// Properties
		public Slot Slot { get; }
		public BoundingBoxAttachment CurrentAttachment { get; }
		public string CurrentAttachmentName { get; }
		public PolygonCollider2D CurrentCollider { get; }
		public bool IsTrigger { get; }
	
		// Constructors
		public BoundingBoxFollower();
		static BoundingBoxFollower();
	
		// Methods
		private void Start();
		private void OnEnable();
		private void HandleRebuild(SkeletonRenderer sr);
		public void Initialize(bool overwrite = false);
		private void AddSkin(Skin skin, int slotIndex);
		private void OnDisable();
		public void ClearState();
		private void DisposeColliders();
		private void LateUpdate();
		private void MatchAttachment(Attachment attachment);
	}
}
