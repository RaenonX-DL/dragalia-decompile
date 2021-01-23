/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public class TwoColorTimeline : CurveTimeline
	{
		// Fields
		public const int ENTRIES = 8;
		protected const int PREV_TIME = -8;
		protected const int PREV_R = -7;
		protected const int PREV_G = -6;
		protected const int PREV_B = -5;
		protected const int PREV_A = -4;
		protected const int PREV_R2 = -3;
		protected const int PREV_G2 = -2;
		protected const int PREV_B2 = -1;
		protected const int R = 1;
		protected const int G = 2;
		protected const int B = 3;
		protected const int A = 4;
		protected const int R2 = 5;
		protected const int G2 = 6;
		protected const int B2 = 7;
		internal float[] frames;
		internal int slotIndex;
	
		// Properties
		public float[] Frames { get; }
		public int SlotIndex { get; set; }
		public override int PropertyId { get; }
	
		// Constructors
		public TwoColorTimeline(int frameCount);
	
		// Methods
		public void SetFrame(int frameIndex, float time, float r, float g, float b, float a, float r2, float g2, float b2);
		public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixPose pose, MixDirection direction);
	}
}
