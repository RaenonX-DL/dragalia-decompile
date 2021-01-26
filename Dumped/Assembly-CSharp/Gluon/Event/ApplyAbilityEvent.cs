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
	public class ApplyAbilityEvent : EventBase<ApplyAbilityEvent>
	{
		// Fields
		[Key]
		[Required]
		public CharacterId owner;
		[Key]
		public int abilityId;
		[Key]
		public int idx;
		[Key]
		public int count;
	
		// Constructors
		public ApplyAbilityEvent();
	}
}
