/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public interface Timeline
	{
		// Properties
		int PropertyId { get; }
	
		// Methods
		void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> events, float alpha, MixPose pose, MixDirection direction);
	}
}
