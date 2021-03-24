/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public class BoneData
	{
		// Fields
		internal int index;
		internal string name;
		internal BoneData parent;
		internal float length;
		internal float x;
		internal float y;
		internal float rotation;
		internal float scaleX;
		internal float scaleY;
		internal float shearX;
		internal float shearY;
		internal TransformMode transformMode;
	
		// Properties
		public int Index { get; }
		public string Name { get; }
		public BoneData Parent { get; }
		public float Length { get; set; }
		public float X { get; set; }
		public float Y { get; set; }
		public float Rotation { get; set; }
		public float ScaleX { get; set; }
		public float ScaleY { get; set; }
		public float ShearX { get; set; }
		public float ShearY { get; set; }
		public TransformMode TransformMode { get; set; }
	
		// Constructors
		public BoneData(int index, string name, BoneData parent);
	
		// Methods
		public override string ToString();
	}
}
