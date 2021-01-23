/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using MessagePack;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	[MessagePackObject]
	public class BRNotifyEvent : EventBase<BRNotifyEvent>
	{
		// Fields
		[Key]
		[Required]
		public BRNotifyEventTypes type;
		[Key]
		public BRNotifyEventParamBase param;
	
		// Nested types
		public enum BRNotifyEventTypes
		{
			GameEnd = 0,
			PulseRadius = 1,
			LevelUp = 2,
			LookingCharacter = 3,
			Extra = 4
		}
	
		// Constructors
		public BRNotifyEvent();
	}
}
