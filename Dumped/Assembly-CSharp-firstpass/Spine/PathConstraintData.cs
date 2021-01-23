/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public class PathConstraintData
	{
		// Fields
		internal string name;
		internal int order;
		internal ExposedList<BoneData> bones;
		internal SlotData target;
		internal PositionMode positionMode;
		internal SpacingMode spacingMode;
		internal RotateMode rotateMode;
		internal float offsetRotation;
		internal float position;
		internal float spacing;
		internal float rotateMix;
		internal float translateMix;
	
		// Properties
		public string Name { get; }
		public int Order { get; set; }
		public ExposedList<BoneData> Bones { get; }
		public SlotData Target { get; set; }
		public PositionMode PositionMode { get; set; }
		public SpacingMode SpacingMode { get; set; }
		public RotateMode RotateMode { get; set; }
		public float OffsetRotation { get; set; }
		public float Position { get; set; }
		public float Spacing { get; set; }
		public float RotateMix { get; set; }
		public float TranslateMix { get; set; }
	
		// Constructors
		public PathConstraintData(string name);
	
		// Methods
		public override string ToString();
	}
}
