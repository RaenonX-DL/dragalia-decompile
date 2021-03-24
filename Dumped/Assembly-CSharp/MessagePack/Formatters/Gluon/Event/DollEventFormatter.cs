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
	public sealed class DollEventFormatter : IMessagePackFormatter<DollEvent>
	{
		// Constructors
		public DollEventFormatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, DollEvent value, IFormatterResolver formatterResolver);
		public DollEvent Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}
