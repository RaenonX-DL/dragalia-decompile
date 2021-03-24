/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public class AttachmentTimeline : Timeline
	{
		// Fields
		internal int slotIndex;
		internal float[] frames;
		private string[] attachmentNames;
	
		// Properties
		public int SlotIndex { get; set; }
		public float[] Frames { get; set; }
		public string[] AttachmentNames { get; set; }
		public int FrameCount { get; }
		public int PropertyId { get; }
	
		// Constructors
		public AttachmentTimeline(int frameCount);
	
		// Methods
		public void SetFrame(int frameIndex, float time, string attachmentName);
		public void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixPose pose, MixDirection direction);
	}
}
