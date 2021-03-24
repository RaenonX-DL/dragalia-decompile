/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public class ColorTimeline : CurveTimeline
	{
		// Fields
		public const int ENTRIES = 5;
		protected const int PREV_TIME = -5;
		protected const int PREV_R = -4;
		protected const int PREV_G = -3;
		protected const int PREV_B = -2;
		protected const int PREV_A = -1;
		protected const int R = 1;
		protected const int G = 2;
		protected const int B = 3;
		protected const int A = 4;
		internal int slotIndex;
		internal float[] frames;
	
		// Properties
		public int SlotIndex { get; set; }
		public float[] Frames { get; set; }
		public override int PropertyId { get; }
	
		// Constructors
		public ColorTimeline(int frameCount);
	
		// Methods
		public void SetFrame(int frameIndex, float time, float r, float g, float b, float a);
		public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixPose pose, MixDirection direction);
	}
}
