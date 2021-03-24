/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using MessagePack;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	[MessagePackObject]
	public class RebornEvent : EventBase<RebornEvent>
	{
		// Fields
		[Key]
		public RebornEventTypes type;
		[Key]
		public List<CharacterId> targetCharas;
	
		// Nested types
		public enum RebornEventTypes : byte
		{
			Wait = 0,
			Reborn = 1
		}
	
		// Constructors
		public RebornEvent();
	}
}
