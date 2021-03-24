/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public class PointAttachment : Attachment
	{
		// Fields
		internal float x;
		internal float y;
		internal float rotation;
	
		// Properties
		public float X { get; set; }
		public float Y { get; set; }
		public float Rotation { get; set; }
	
		// Constructors
		public PointAttachment(string name);
	
		// Methods
		public void ComputeWorldPosition(Bone bone, out float ox, out float oy);
		public float ComputeWorldRotation(Bone bone);
	}
}
