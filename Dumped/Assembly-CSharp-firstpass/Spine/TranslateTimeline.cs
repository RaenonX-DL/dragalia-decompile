/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public class TranslateTimeline : CurveTimeline
	{
		// Fields
		public const int ENTRIES = 3;
		protected const int PREV_TIME = -3;
		protected const int PREV_X = -2;
		protected const int PREV_Y = -1;
		protected const int X = 1;
		protected const int Y = 2;
		internal int boneIndex;
		internal float[] frames;
	
		// Properties
		public int BoneIndex { get; set; }
		public float[] Frames { get; set; }
		public override int PropertyId { get; }
	
		// Constructors
		public TranslateTimeline(int frameCount);
	
		// Methods
		public void SetFrame(int frameIndex, float time, float x, float y);
		public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixPose pose, MixDirection direction);
	}
}
