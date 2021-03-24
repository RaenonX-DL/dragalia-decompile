/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public static class SkeletonExtensions
	{
		// Extension methods
		public static bool IsWeighted(this VertexAttachment va);
		public static bool IsRenderable(this Attachment a);
		public static bool InheritsRotation(this TransformMode mode);
		public static bool InheritsScale(this TransformMode mode);
		internal static void SetPropertyToSetupPose(this Skeleton skeleton, int propertyID);
		public static void SetDrawOrderToSetupPose(this Skeleton skeleton);
		public static void SetColorToSetupPose(this Slot slot);
		public static void SetAttachmentToSetupPose(this Slot slot);
		public static void SetSlotAttachmentToSetupPose(this Skeleton skeleton, int slotIndex);
		public static void PoseWithAnimation(this Skeleton skeleton, string animationName, float time, bool loop = false);
		public static void PoseSkeleton(this Animation animation, Skeleton skeleton, float time, bool loop = false);
		public static void SetKeyedItemsToSetupPose(this Animation animation, Skeleton skeleton);
		public static void FindNamesForSlot(this Skin skin, string slotName, SkeletonData skeletonData, List<string> results);
		public static void FindAttachmentsForSlot(this Skin skin, string slotName, SkeletonData skeletonData, List<Attachment> results);
	}
}
