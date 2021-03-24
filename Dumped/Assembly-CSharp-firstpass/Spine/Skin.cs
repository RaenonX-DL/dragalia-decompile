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
	public class Skin
	{
		// Fields
		internal string name;
		private Dictionary<AttachmentKeyTuple, Attachment> attachments;
	
		// Properties
		public string Name { get; }
		public Dictionary<AttachmentKeyTuple, Attachment> Attachments { get; }
	
		// Nested types
		public struct AttachmentKeyTuple
		{
			// Fields
			public readonly int slotIndex;
			public readonly string name;
			internal readonly int nameHashCode;
	
			// Constructors
			public AttachmentKeyTuple(int slotIndex, string name);
		}
	
		private class AttachmentKeyTupleComparer : IEqualityComparer<AttachmentKeyTuple>
		{
			// Fields
			internal static readonly AttachmentKeyTupleComparer Instance;
	
			// Constructors
			public AttachmentKeyTupleComparer();
			static AttachmentKeyTupleComparer();
	
			// Methods
			bool System.Collections.Generic.IEqualityComparer<Spine.Skin.AttachmentKeyTuple>.Equals(AttachmentKeyTuple o1, AttachmentKeyTuple o2);
			int System.Collections.Generic.IEqualityComparer<Spine.Skin.AttachmentKeyTuple>.GetHashCode(AttachmentKeyTuple o);
		}
	
		// Constructors
		public Skin(string name);
	
		// Methods
		public void AddAttachment(int slotIndex, string name, Attachment attachment);
		public Attachment GetAttachment(int slotIndex, string name);
		public void FindNamesForSlot(int slotIndex, List<string> names);
		public void FindAttachmentsForSlot(int slotIndex, List<Attachment> attachments);
		public override string ToString();
		internal void AttachAll(Skeleton skeleton, Skin oldSkin);
	}
}
