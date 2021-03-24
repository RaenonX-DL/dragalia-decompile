/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine.Unity
{
	public class SpineAttachment : SpineAttributeBase
	{
		// Fields
		public bool returnAttachmentPath;
		public bool currentSkinOnly;
		public bool placeholdersOnly;
		public string skinField;
		public string slotField;
	
		// Nested types
		public struct Hierarchy
		{
			// Fields
			public string skin;
			public string slot;
			public string name;
	
			// Constructors
			public Hierarchy(string fullPath);
		}
	
		// Constructors
		public SpineAttachment(bool currentSkinOnly = true, bool returnAttachmentPath = false, bool placeholdersOnly = false, string slotField = "", string dataField = "", string skinField = "", bool includeNone = true, bool fallbackToTextField = false);
	
		// Methods
		public static Hierarchy GetHierarchy(string fullPath);
		public static Attachment GetAttachment(string attachmentPath, SkeletonData skeletonData);
		public static Attachment GetAttachment(string attachmentPath, SkeletonDataAsset skeletonDataAsset);
	}
}
