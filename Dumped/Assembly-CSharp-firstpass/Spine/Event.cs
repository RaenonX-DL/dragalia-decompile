/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public class Event
	{
		// Fields
		internal readonly EventData data;
		internal readonly float time;
		internal int intValue;
		internal float floatValue;
		internal string stringValue;
	
		// Properties
		public EventData Data { get; }
		public float Time { get; }
		public int Int { get; set; }
		public float Float { get; set; }
		public string String { get; set; }
	
		// Constructors
		public Event(float time, EventData data);
	
		// Methods
		public override string ToString();
	}
}
