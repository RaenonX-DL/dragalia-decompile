/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public class PathConstraintPositionTimeline : CurveTimeline
	{
		// Fields
		public const int ENTRIES = 2;
		protected const int PREV_TIME = -2;
		protected const int PREV_VALUE = -1;
		protected const int VALUE = 1;
		internal int pathConstraintIndex;
		internal float[] frames;
	
		// Properties
		public override int PropertyId { get; }
		public int PathConstraintIndex { get; set; }
		public float[] Frames { get; set; }
	
		// Constructors
		public PathConstraintPositionTimeline(int frameCount);
	
		// Methods
		public void SetFrame(int frameIndex, float time, float value);
		public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixPose pose, MixDirection direction);
	}
}
