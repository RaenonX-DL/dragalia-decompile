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
	public sealed class DebugInspectionResponseFormatter : IMessagePackFormatter<DebugInspectionResponse>
	{
		// Constructors
		public DebugInspectionResponseFormatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, DebugInspectionResponse value, IFormatterResolver formatterResolver);
		public DebugInspectionResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}
