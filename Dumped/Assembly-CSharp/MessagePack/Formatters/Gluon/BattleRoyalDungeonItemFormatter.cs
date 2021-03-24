/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using MessagePack;
using MessagePack.Formatters;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MessagePack.Formatters.Gluon
{
	public sealed class BattleRoyalDungeonItemFormatter : IMessagePackFormatter<BattleRoyalDungeonItem>
	{
		// Constructors
		public BattleRoyalDungeonItemFormatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, BattleRoyalDungeonItem value, IFormatterResolver formatterResolver);
		public BattleRoyalDungeonItem Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}
