/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;
using MessagePack;
using MessagePack.Formatters;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class EventD00562Formatter : IMessagePackFormatter<EventD00562>
	{
		// Constructors
		public EventD00562Formatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, EventD00562 value, IFormatterResolver formatterResolver);
		public EventD00562 Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}
