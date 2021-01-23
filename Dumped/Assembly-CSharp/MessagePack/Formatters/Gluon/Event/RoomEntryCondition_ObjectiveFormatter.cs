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
	public sealed class RoomEntryCondition_ObjectiveFormatter : IMessagePackFormatter<RoomEntryCondition.Objective>
	{
		// Constructors
		public RoomEntryCondition_ObjectiveFormatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, RoomEntryCondition.Objective value, IFormatterResolver formatterResolver);
		public RoomEntryCondition.Objective Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}
