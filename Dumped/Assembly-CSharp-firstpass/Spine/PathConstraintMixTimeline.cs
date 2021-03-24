/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public class PathConstraintMixTimeline : CurveTimeline
	{
		// Fields
		public const int ENTRIES = 3;
		private const int PREV_TIME = -3;
		private const int PREV_ROTATE = -2;
		private const int PREV_TRANSLATE = -1;
		private const int ROTATE = 1;
		private const int TRANSLATE = 2;
		internal int pathConstraintIndex;
		internal float[] frames;
	
		// Properties
		public int PathConstraintIndex { get; set; }
		public float[] Frames { get; set; }
		public override int PropertyId { get; }
	
		// Constructors
		public PathConstraintMixTimeline(int frameCount);
	
		// Methods
		public void SetFrame(int frameIndex, float time, float rotateMix, float translateMix);
		public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixPose pose, MixDirection direction);
	}
}
