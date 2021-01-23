/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public class Animation
	{
		// Fields
		internal ExposedList<Timeline> timelines;
		internal float duration;
		internal string name;
	
		// Properties
		public string Name { get; }
		public ExposedList<Timeline> Timelines { get; set; }
		public float Duration { get; set; }
	
		// Constructors
		public Animation(string name, ExposedList<Timeline> timelines, float duration);
	
		// Methods
		public void Apply(Skeleton skeleton, float lastTime, float time, bool loop, ExposedList<Event> events, float alpha, MixPose pose, MixDirection direction);
		internal static int BinarySearch(float[] values, float target, int step);
		internal static int BinarySearch(float[] values, float target);
		internal static int LinearSearch(float[] values, float target, int step);
	}
}
