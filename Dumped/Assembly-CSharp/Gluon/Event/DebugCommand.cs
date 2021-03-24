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
	public class DebugCommand : EventBase<DebugCommand>
	{
		// Fields
		[Key]
		[Required]
		public DebugCommandTypes type;
		[Key]
		public bool boolValue;
		[Key]
		public int intValue;
		[Key]
		public float floatValue;
		[Key]
		[Required]
		public CharacterId charaId;
	
		// Nested types
		public enum DebugCommandTypes
		{
			None = 0,
			QuestClear = 1,
			BRWarp = 2,
			KillingEnemy = 3,
			EnemyParameterMaxHP = 4,
			EnemyParameterATK = 5,
			EnemyParameterOD = 6,
			EnemyParameterBreak = 7
		}
	
		// Constructors
		public DebugCommand();
	}
}
