/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public class Slot
	{
		// Fields
		internal SlotData data;
		internal Bone bone;
		internal float r;
		internal float g;
		internal float b;
		internal float a;
		internal float r2;
		internal float g2;
		internal float b2;
		internal bool hasSecondColor;
		internal Attachment attachment;
		internal float attachmentTime;
		internal ExposedList<float> attachmentVertices;
	
		// Properties
		public SlotData Data { get; }
		public Bone Bone { get; }
		public Skeleton Skeleton { get; }
		public float R { get; set; }
		public float G { get; set; }
		public float B { get; set; }
		public float A { get; set; }
		public float R2 { get; set; }
		public float G2 { get; set; }
		public float B2 { get; set; }
		public bool HasSecondColor { get; set; }
		public Attachment Attachment { get; set; }
		public float AttachmentTime { get; set; }
		public ExposedList<float> AttachmentVertices { get; set; }
	
		// Constructors
		public Slot(SlotData data, Bone bone);
	
		// Methods
		public void SetToSetupPose();
		public override string ToString();
	}
}
