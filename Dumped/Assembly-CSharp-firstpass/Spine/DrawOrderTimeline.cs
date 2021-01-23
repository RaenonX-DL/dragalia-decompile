/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public class DrawOrderTimeline : Timeline
	{
		// Fields
		internal float[] frames;
		private int[][] drawOrders;
	
		// Properties
		public float[] Frames { get; set; }
		public int[][] DrawOrders { get; set; }
		public int FrameCount { get; }
		public int PropertyId { get; }
	
		// Constructors
		public DrawOrderTimeline(int frameCount);
	
		// Methods
		public void SetFrame(int frameIndex, float time, int[] drawOrder);
		public void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixPose pose, MixDirection direction);
	}
}
