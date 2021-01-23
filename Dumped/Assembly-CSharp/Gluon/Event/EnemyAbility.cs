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
	public class EnemyAbility : EventBase<EnemyAbility>
	{
		// Fields
		[Key]
		public int dataId;
		[Key]
		public States state;
		[Key]
		public int value;
		[Key]
		public CharacterId target;
		[Key]
		public CharacterId owner;
	
		// Nested types
		public enum States
		{
			None = 0,
			Show = 1,
			Hide = 2,
			Rampage = 3,
			PlayDirection = 4,
			CancelGoldenBarrier = 5,
			ChildPlay = 6
		}
	
		// Constructors
		public EnemyAbility();
	}
}
