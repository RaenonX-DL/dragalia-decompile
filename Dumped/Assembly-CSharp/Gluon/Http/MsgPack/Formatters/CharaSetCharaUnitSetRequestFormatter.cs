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
	public sealed class CharaSetCharaUnitSetRequestFormatter : IMessagePackFormatter<CharaSetCharaUnitSetRequest>
	{
		// Fields
		private readonly AutomataDictionary ____keyMapping;
		private readonly byte[][] ____stringByteKeys;
	
		// Constructors
		public CharaSetCharaUnitSetRequestFormatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, CharaSetCharaUnitSetRequest value, IFormatterResolver formatterResolver);
		public CharaSetCharaUnitSetRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}
