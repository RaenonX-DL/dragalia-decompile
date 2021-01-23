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
	public class DebuffExtraDamage : EventBase<DebuffExtraDamage>
	{
		// Fields
		[Key]
		[Required]
		public CharacterId target;
		[ActionConditionId]
		[Key]
		public int actionConditionId;
		[Key]
		public int damage;
		[Key]
		public CharacterId from;
		[Key]
		public float extraElementRate;
	
		// Constructors
		public DebuffExtraDamage();
	}
}
