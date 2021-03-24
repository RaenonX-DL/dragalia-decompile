/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public class SlotData
	{
		// Fields
		internal int index;
		internal string name;
		internal BoneData boneData;
		internal float r;
		internal float g;
		internal float b;
		internal float a;
		internal float r2;
		internal float g2;
		internal float b2;
		internal bool hasSecondColor;
		internal string attachmentName;
		internal BlendMode blendMode;
	
		// Properties
		public int Index { get; }
		public string Name { get; }
		public BoneData BoneData { get; }
		public float R { get; set; }
		public float G { get; set; }
		public float B { get; set; }
		public float A { get; set; }
		public float R2 { get; set; }
		public float G2 { get; set; }
		public float B2 { get; set; }
		public bool HasSecondColor { get; set; }
		public string AttachmentName { get; set; }
		public BlendMode BlendMode { get; set; }
	
		// Constructors
		public SlotData(int index, string name, BoneData boneData);
	
		// Methods
		public override string ToString();
	}
}
