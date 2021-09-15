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
	public class ConsumeUtpToRecoverHpEvent : EventBase<ConsumeUtpToRecoverHpEvent>
	{
		// Fields
		[Key]
		[Required]
		public CharacterId owner;
		[Key]
		public int hp;
		[Key]
		public float prevHp;
		[Key]
		public float utp;
		[Key]
		public int recoveryHp;
	
		// Constructors
		public ConsumeUtpToRecoverHpEvent();
	}
}
