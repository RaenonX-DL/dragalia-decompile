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
	public class ResetBuffRequest : EventBase<ResetBuffRequest>
	{
		// Fields
		[Key]
		[Required]
		public CharacterId character;
		[Key]
		public int conditionId;
		[Key]
		public int abilityId;
		[Key]
		public int productId;
	
		// Constructors
		public ResetBuffRequest();
	}
}
