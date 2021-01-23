/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MessagePack;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	[MessagePackObject]
	public class BRNotifyExtraParam : BRNotifyEventParamBase
	{
		// Fields
		[Key]
		[Required]
		public CharacterId targetCharacter;
		[Key]
		[Required]
		public int value1;
		[Key]
		[Required]
		public int value2;
		[Key]
		[Required]
		public int value3;
	
		// Constructors
		public BRNotifyExtraParam();
	}
}
