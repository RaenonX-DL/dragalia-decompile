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
	public sealed class BarrelEventTypeFormatter : IMessagePackFormatter<BarrelBombDungeonObject.BarrelEventType>
	{
		// Constructors
		public BarrelEventTypeFormatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, BarrelBombDungeonObject.BarrelEventType value, IFormatterResolver formatterResolver);
		public BarrelBombDungeonObject.BarrelEventType Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}
