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
	public class BulletEvent : EventBase<BulletEvent>
	{
		// Fields
		[Key]
		public BulletEventTypes type;
		[Key]
		[Required]
		public CharacterId character;
		[Key]
		public int bulletId;
		[Key]
		public byte flags;
		[Key]
		public CharacterId target;
	
		// Nested types
		public enum BulletEventTypes : byte
		{
			None = 0,
			HitProcess = 1,
			TargetChanged = 2
		}
	
		// Constructors
		public BulletEvent();
	}
}
