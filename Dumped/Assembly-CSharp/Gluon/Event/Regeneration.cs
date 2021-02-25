/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using MessagePack;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	[MessagePackObject]
	public class Regeneration : EventBase<Regeneration>
	{
		// Fields
		[Key]
		[Required]
		public CharacterId target;
		[Key]
		public short type;
		[Key]
		[Required]
		public int[] healValues;
		[Key]
		public Dictionary<CharacterId, int> froms;
		[Key]
		public int damageValue;
		[Key]
		public bool isFollower;
		[Key]
		public int uniqueIconType;
		[Key]
		public float dragonTimerDamage;
	
		// Constructors
		public Regeneration();
	}
}
