﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MessagePack;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	[MessagePackObject]
	public class BRNotifyLevelUpEventParam : BRNotifyEventParamBase
	{
		// Fields
		[Key]
		[Required]
		public CharacterId targetCharacter;
		[Key]
		[Required]
		public int level;
	
		// Constructors
		public BRNotifyLevelUpEventParam();
	}
}
