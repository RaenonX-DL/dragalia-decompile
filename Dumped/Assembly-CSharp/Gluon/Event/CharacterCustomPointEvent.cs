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
	public class CharacterCustomPointEvent : EventBase<CharacterCustomPointEvent>
	{
		// Fields
		[Key]
		[Required]
		public int type;
		[Key]
		[Required]
		public CharacterId target;
		[Key]
		[Required]
		public int index;
		[Key]
		[Required]
		public int value;
	
		// Constructors
		public CharacterCustomPointEvent();
	}
}
