/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public class IkConstraintTimeline : CurveTimeline
	{
		// Fields
		public const int ENTRIES = 3;
		private const int PREV_TIME = -3;
		private const int PREV_MIX = -2;
		private const int PREV_BEND_DIRECTION = -1;
		private const int MIX = 1;
		private const int BEND_DIRECTION = 2;
		internal int ikConstraintIndex;
		internal float[] frames;
	
		// Properties
		public int IkConstraintIndex { get; set; }
		public float[] Frames { get; set; }
		public override int PropertyId { get; }
	
		// Constructors
		public IkConstraintTimeline(int frameCount);
	
		// Methods
		public void SetFrame(int frameIndex, float time, float mix, int bendDirection);
		public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixPose pose, MixDirection direction);
	}
}
