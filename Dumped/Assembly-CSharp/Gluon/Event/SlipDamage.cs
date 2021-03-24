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
	public class SlipDamage : EventBase<SlipDamage>
	{
		// Fields
		[Key]
		[Required]
		public CharacterId target;
		[Key]
		public short type;
		[Key]
		public int damage;
		[Key]
		public CharacterId attacker;
		[Key]
		public bool isFollower;
		[Key]
		public Dictionary<CharacterId, int> froms;
	
		// Constructors
		public SlipDamage();
	}
}
