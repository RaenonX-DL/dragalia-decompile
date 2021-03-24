/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public class PathConstraint : IConstraint
	{
		// Fields
		private const int NONE = -1;
		private const int BEFORE = -2;
		private const int AFTER = -3;
		private const float Epsilon = 1E-05f;
		internal PathConstraintData data;
		internal ExposedList<Bone> bones;
		internal Slot target;
		internal float position;
		internal float spacing;
		internal float rotateMix;
		internal float translateMix;
		internal ExposedList<float> spaces;
		internal ExposedList<float> positions;
		internal ExposedList<float> world;
		internal ExposedList<float> curves;
		internal ExposedList<float> lengths;
		internal float[] segments;
	
		// Properties
		public int Order { get; }
		public float Position { get; set; }
		public float Spacing { get; set; }
		public float RotateMix { get; set; }
		public float TranslateMix { get; set; }
		public ExposedList<Bone> Bones { get; }
		public Slot Target { get; set; }
		public PathConstraintData Data { get; }
	
		// Constructors
		public PathConstraint(PathConstraintData data, Skeleton skeleton);
	
		// Methods
		public void Apply();
		public void Update();
		private float[] ComputeWorldPositions(PathAttachment path, int spacesCount, bool tangents, bool percentPosition, bool percentSpacing);
		private static void AddBeforePosition(float p, float[] temp, int i, float[] output, int o);
		private static void AddAfterPosition(float p, float[] temp, int i, float[] output, int o);
		private static void AddCurvePosition(float p, float x1, float y1, float cx1, float cy1, float cx2, float cy2, float x2, float y2, float[] output, int o, bool tangents);
	}
}
