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
	public class WarpEvent : EventBase<WarpEvent>
	{
		// Fields
		[Key]
		public WarpEventTypes type;
		[Key]
		public int roomGroup;
		[Key]
		public int doorKind;
		[Key]
		public bool checkIsDead;
		[Key]
		public bool isForceReturn;
		[Key]
		public int lockActorId;
		[Key]
		public CharacterId lockMultiPlayId;
		[Key]
		public bool isSuccess;
	
		// Nested types
		public enum WarpEventTypes : byte
		{
			LockRequest = 0,
			UnlockRequest = 1,
			Lock = 2,
			Unlock = 3
		}
	
		// Constructors
		public WarpEvent();
	}
}
