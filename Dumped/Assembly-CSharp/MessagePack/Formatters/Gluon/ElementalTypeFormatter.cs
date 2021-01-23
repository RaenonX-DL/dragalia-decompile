/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using MessagePack;
using MessagePack.Formatters;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MessagePack.Formatters.Gluon
{
	public sealed class ElementalTypeFormatter : IMessagePackFormatter<ElementalType>
	{
		// Constructors
		public ElementalTypeFormatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, ElementalType value, IFormatterResolver formatterResolver);
		public ElementalType Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}
