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
		[Key]
		public int level;
		[Key]
		public float duration;
		[Key]
		public BulletEventParamBase param;
	
		// Nested types
		public enum BulletEventTypes : byte
		{
			None = 0,
			HitProcess = 1,
			TargetChanged = 2,
			ShikigamiLevelUp = 3,
			ShikigamiRemove = 4,
			ShikigamiDuration = 5,
			SyncMove = 6
		}
	
		// Constructors
		public BulletEvent();
	}
}
