﻿/*
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
	public class PlayerEvent : EventBase<PlayerEvent>
	{
		// Fields
		[Key]
		public PlayerEventTypes type;
		[Key]
		public bool flag;
	
		// Nested types
		public enum PlayerEventTypes : byte
		{
			UpdateAllDeadConfirmed = 0
		}
	
		// Constructors
		public PlayerEvent();
	}
}
