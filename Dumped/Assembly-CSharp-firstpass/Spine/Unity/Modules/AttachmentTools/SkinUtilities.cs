/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine.Unity.Modules.AttachmentTools
{
	public static class SkinUtilities
	{
		// Extension methods
		public static Skin UnshareSkin(this Skeleton skeleton, bool includeDefaultSkin, bool unshareAttachments, AnimationState state = null);
		public static Skin GetClonedSkin(this Skeleton skeleton, string newSkinName, bool includeDefaultSkin = false, bool cloneAttachments = false, bool cloneMeshesAsLinked = true);
		public static Skin GetClone(this Skin original);
		public static void SetAttachment(this Skin skin, string slotName, string keyName, Attachment attachment, Skeleton skeleton);
		public static Attachment GetAttachment(this Skin skin, string slotName, string keyName, Skeleton skeleton);
		public static void SetAttachment(this Skin skin, int slotIndex, string keyName, Attachment attachment);
		public static bool RemoveAttachment(this Skin skin, string slotName, string keyName, Skeleton skeleton);
		public static bool RemoveAttachment(this Skin skin, int slotIndex, string keyName);
		public static void Clear(this Skin skin);
		public static void Append(this Skin destination, Skin source);
		public static void CopyTo(this Skin source, Skin destination, bool overwrite, bool cloneAttachments, bool cloneMeshesAsLinked = true);
	}
}
