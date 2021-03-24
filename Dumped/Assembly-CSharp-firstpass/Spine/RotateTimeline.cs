/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public class RotateTimeline : CurveTimeline
	{
		// Fields
		public const int ENTRIES = 2;
		internal const int PREV_TIME = -2;
		internal const int PREV_ROTATION = -1;
		internal const int ROTATION = 1;
		internal int boneIndex;
		internal float[] frames;
	
		// Properties
		public int BoneIndex { get; set; }
		public float[] Frames { get; set; }
		public override int PropertyId { get; }
	
		// Constructors
		public RotateTimeline(int frameCount);
	
		// Methods
		public void SetFrame(int frameIndex, float time, float degrees);
		public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixPose pose, MixDirection direction);
	}
}
