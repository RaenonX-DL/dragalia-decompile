/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using MessagePack;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	[MessagePackObject]
	public class ClearTimerEvent : EventBase<ClearTimerEvent>
	{
		// Fields
		[Key]
		[Required]
		public EventTypes eventType;
	
		// Nested types
		public enum EventTypes
		{
			Start = 0,
			Pause = 1,
			Restart = 2
		}
	
		// Constructors
		public ClearTimerEvent();
	}
}
