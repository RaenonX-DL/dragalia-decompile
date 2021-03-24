/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using MessagePack;
using MessagePack.Formatters;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class BRInitWorldFormatter : IMessagePackFormatter<BRInitWorld>
	{
		// Constructors
		public BRInitWorldFormatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, BRInitWorld value, IFormatterResolver formatterResolver);
		public BRInitWorld Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}
