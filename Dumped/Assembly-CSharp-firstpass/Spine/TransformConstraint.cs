/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public class TransformConstraint : IConstraint
	{
		// Fields
		internal TransformConstraintData data;
		internal ExposedList<Bone> bones;
		internal Bone target;
		internal float rotateMix;
		internal float translateMix;
		internal float scaleMix;
		internal float shearMix;
	
		// Properties
		public TransformConstraintData Data { get; }
		public int Order { get; }
		public ExposedList<Bone> Bones { get; }
		public Bone Target { get; set; }
		public float RotateMix { get; set; }
		public float TranslateMix { get; set; }
		public float ScaleMix { get; set; }
		public float ShearMix { get; set; }
	
		// Constructors
		public TransformConstraint(TransformConstraintData data, Skeleton skeleton);
	
		// Methods
		public void Apply();
		public void Update();
		private void ApplyAbsoluteWorld();
		private void ApplyRelativeWorld();
		private void ApplyAbsoluteLocal();
		private void ApplyRelativeLocal();
		public override string ToString();
	}
}
