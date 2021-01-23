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
	public sealed class AreaTrapEventTypeFormatter : IMessagePackFormatter<AreaTrapDungeonObject.AreaTrapEventType>
	{
		// Constructors
		public AreaTrapEventTypeFormatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, AreaTrapDungeonObject.AreaTrapEventType value, IFormatterResolver formatterResolver);
		public AreaTrapDungeonObject.AreaTrapEventType Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}
