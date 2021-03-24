/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public class IkConstraint : IConstraint
	{
		// Fields
		internal IkConstraintData data;
		internal ExposedList<Bone> bones;
		internal Bone target;
		internal float mix;
		internal int bendDirection;
	
		// Properties
		public IkConstraintData Data { get; }
		public int Order { get; }
		public ExposedList<Bone> Bones { get; }
		public Bone Target { get; set; }
		public int BendDirection { get; set; }
		public float Mix { get; set; }
	
		// Constructors
		public IkConstraint(IkConstraintData data, Skeleton skeleton);
	
		// Methods
		public void Apply();
		public void Update();
		public override string ToString();
		public static void Apply(Bone bone, float targetX, float targetY, float alpha);
		public static void Apply(Bone parent, Bone child, float targetX, float targetY, int bendDir, float alpha);
	}
}
