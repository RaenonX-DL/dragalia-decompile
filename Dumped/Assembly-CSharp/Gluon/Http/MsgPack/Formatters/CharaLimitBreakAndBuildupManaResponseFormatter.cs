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
	public sealed class CharaLimitBreakAndBuildupManaResponseFormatter : IMessagePackFormatter<CharaLimitBreakAndBuildupManaResponse>
	{
		// Fields
		private readonly AutomataDictionary ____keyMapping;
		private readonly byte[][] ____stringByteKeys;
	
		// Constructors
		public CharaLimitBreakAndBuildupManaResponseFormatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, CharaLimitBreakAndBuildupManaResponse value, IFormatterResolver formatterResolver);
		public CharaLimitBreakAndBuildupManaResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}
