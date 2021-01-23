/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public class EventTimeline : Timeline
	{
		// Fields
		internal float[] frames;
		private Event[] events;
	
		// Properties
		public float[] Frames { get; set; }
		public Event[] Events { get; set; }
		public int FrameCount { get; }
		public int PropertyId { get; }
	
		// Constructors
		public EventTimeline(int frameCount);
	
		// Methods
		public void SetFrame(int frameIndex, Event e);
		public void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixPose pose, MixDirection direction);
	}
}
