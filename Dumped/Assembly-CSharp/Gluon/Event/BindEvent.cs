/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using MessagePack;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	[MessagePackObject]
	public class BindEvent : EventBase<BindEvent>
	{
		// Fields
		[Key]
		public Types eventType;
		[Key]
		public long bindEventId;
		[Key]
		public CharacterId owner;
		[Key]
		public List<CharacterId> targets;
		[Key]
		public Vector3 position;
		[Key]
		public byte flags;
		[Key]
		public byte effectTrigger;
	
		// Nested types
		public enum Types
		{
			Catch = 0,
			Confirm = 1,
			Release = 2
		}
	
		// Constructors
		public BindEvent();
	}
}
