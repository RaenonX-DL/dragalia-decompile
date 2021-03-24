/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class BattleRoyalStartRoyalMultiResponseFormatter : IMessagePackFormatter<BattleRoyalStartRoyalMultiResponse>
	{
		// Fields
		private readonly AutomataDictionary ____keyMapping;
		private readonly byte[][] ____stringByteKeys;
	
		// Constructors
		public BattleRoyalStartRoyalMultiResponseFormatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, BattleRoyalStartRoyalMultiResponse value, IFormatterResolver formatterResolver);
		public BattleRoyalStartRoyalMultiResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}
