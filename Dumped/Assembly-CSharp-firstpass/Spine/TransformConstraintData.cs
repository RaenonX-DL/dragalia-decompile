/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public class TransformConstraintData
	{
		// Fields
		internal string name;
		internal int order;
		internal ExposedList<BoneData> bones;
		internal BoneData target;
		internal float rotateMix;
		internal float translateMix;
		internal float scaleMix;
		internal float shearMix;
		internal float offsetRotation;
		internal float offsetX;
		internal float offsetY;
		internal float offsetScaleX;
		internal float offsetScaleY;
		internal float offsetShearY;
		internal bool relative;
		internal bool local;
	
		// Properties
		public string Name { get; }
		public int Order { get; set; }
		public ExposedList<BoneData> Bones { get; }
		public BoneData Target { get; set; }
		public float RotateMix { get; set; }
		public float TranslateMix { get; set; }
		public float ScaleMix { get; set; }
		public float ShearMix { get; set; }
		public float OffsetRotation { get; set; }
		public float OffsetX { get; set; }
		public float OffsetY { get; set; }
		public float OffsetScaleX { get; set; }
		public float OffsetScaleY { get; set; }
		public float OffsetShearY { get; set; }
		public bool Relative { get; set; }
		public bool Local { get; set; }
	
		// Constructors
		public TransformConstraintData(string name);
	
		// Methods
		public override string ToString();
	}
}
