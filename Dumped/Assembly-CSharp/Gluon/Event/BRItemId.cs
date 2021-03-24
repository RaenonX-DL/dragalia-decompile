/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Dungeon;
using MessagePack;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	[MessagePackObject]
	public struct BRItemId
	{
		// Fields
		public static readonly BRItemId None;
		[Key]
		public BRItemCreateType type;
		[Key]
		public uint value;
	
		// Nested types
		public enum BRItemCreateType : byte
		{
			None = 0,
			Field = 1,
			PlayerDead = 2,
			EnemyDead = 3,
			Gimmick = 4
		}
	
		// Constructors
		static BRItemId();
	
		// Methods
		public bool IsSame(BRItemId id);
		public static BRItemId FromField(int index);
		public static BRItemId FromPlayerCharacter(PlayerCharacter chara, int index);
		public static BRItemId FromEnemyCharacter(EnemyCharacter chara, int index);
		public static BRItemId FromDungeonGimmick(DungeonObjectStatus gimmick);
	}
}
