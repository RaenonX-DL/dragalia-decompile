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
	public sealed class AtgenSupportCrestSlotType1ListFormatter : IMessagePackFormatter<AtgenSupportCrestSlotType1List>
	{
		// Fields
		private readonly AutomataDictionary ____keyMapping;
		private readonly byte[][] ____stringByteKeys;
	
		// Constructors
		public AtgenSupportCrestSlotType1ListFormatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, AtgenSupportCrestSlotType1List value, IFormatterResolver formatterResolver);
		public AtgenSupportCrestSlotType1List Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}
