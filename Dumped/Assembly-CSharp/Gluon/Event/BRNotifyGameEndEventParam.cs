﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;
using MessagePack;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	[MessagePackObject]
	public class BRNotifyGameEndEventParam : BRNotifyEventParamBase
	{
		// Fields
		[Key]
		[Required]
		public CharacterId winnerCharacter;
		[Key]
		[Required]
		public CharacterId lastDeadCharacter;
	
		// Constructors
		public BRNotifyGameEndEventParam();
	}
}
