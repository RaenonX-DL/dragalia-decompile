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
	public class DebugCommand : EventBase<DebugCommand>
	{
		// Fields
		[Key]
		[Required]
		public DebugCommandTypes type;
		[Key]
		public bool boolValue;
	
		// Nested types
		public enum DebugCommandTypes
		{
			None = 0,
			QuestClear = 1,
			BRWarp = 2,
			KillingEnemy = 3
		}
	
		// Constructors
		public DebugCommand();
	}
}
