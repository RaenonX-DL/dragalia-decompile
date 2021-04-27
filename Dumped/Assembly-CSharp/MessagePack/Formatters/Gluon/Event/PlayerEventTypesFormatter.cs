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
	public sealed class PlayerEventTypesFormatter : IMessagePackFormatter<PlayerEvent.PlayerEventTypes>
	{
		// Constructors
		public PlayerEventTypesFormatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, PlayerEvent.PlayerEventTypes value, IFormatterResolver formatterResolver);
		public PlayerEvent.PlayerEventTypes Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}
