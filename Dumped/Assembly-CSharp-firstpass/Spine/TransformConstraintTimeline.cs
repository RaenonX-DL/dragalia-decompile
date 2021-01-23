/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public class TransformConstraintTimeline : CurveTimeline
	{
		// Fields
		public const int ENTRIES = 5;
		private const int PREV_TIME = -5;
		private const int PREV_ROTATE = -4;
		private const int PREV_TRANSLATE = -3;
		private const int PREV_SCALE = -2;
		private const int PREV_SHEAR = -1;
		private const int ROTATE = 1;
		private const int TRANSLATE = 2;
		private const int SCALE = 3;
		private const int SHEAR = 4;
		internal int transformConstraintIndex;
		internal float[] frames;
	
		// Properties
		public int TransformConstraintIndex { get; set; }
		public float[] Frames { get; set; }
		public override int PropertyId { get; }
	
		// Constructors
		public TransformConstraintTimeline(int frameCount);
	
		// Methods
		public void SetFrame(int frameIndex, float time, float rotateMix, float translateMix, float scaleMix, float shearMix);
		public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixPose pose, MixDirection direction);
	}
}
