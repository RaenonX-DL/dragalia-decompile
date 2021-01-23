/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public abstract class CurveTimeline : Timeline
	{
		// Fields
		protected const float LINEAR = 0f;
		protected const float STEPPED = 1f;
		protected const float BEZIER = 2f;
		protected const int BEZIER_SIZE = 19;
		private float[] curves;
	
		// Properties
		public int FrameCount { get; }
		public abstract int PropertyId { get; }
	
		// Constructors
		public CurveTimeline(int frameCount);
	
		// Methods
		public abstract void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixPose pose, MixDirection direction);
		public void SetLinear(int frameIndex);
		public void SetStepped(int frameIndex);
		public void SetCurve(int frameIndex, float cx1, float cy1, float cx2, float cy2);
		public float GetCurvePercent(int frameIndex, float percent);
		public float GetCurveType(int frameIndex);
	}
}
