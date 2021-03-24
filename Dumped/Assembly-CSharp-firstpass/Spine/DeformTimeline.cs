/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public class DeformTimeline : CurveTimeline
	{
		// Fields
		internal int slotIndex;
		internal float[] frames;
		internal float[][] frameVertices;
		internal VertexAttachment attachment;
	
		// Properties
		public int SlotIndex { get; set; }
		public float[] Frames { get; set; }
		public float[][] Vertices { get; set; }
		public VertexAttachment Attachment { get; set; }
		public override int PropertyId { get; }
	
		// Constructors
		public DeformTimeline(int frameCount);
	
		// Methods
		public void SetFrame(int frameIndex, float time, float[] vertices);
		public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixPose pose, MixDirection direction);
	}
}
