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
	public sealed class ChangeAbnormalStatusFormatter : IMessagePackFormatter<ChangeAbnormalStatus>
	{
		// Constructors
		public ChangeAbnormalStatusFormatter();
	
		// Methods
		public int Serialize(ref byte[] bytes, int offset, ChangeAbnormalStatus value, IFormatterResolver formatterResolver);
		public ChangeAbnormalStatus Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize);
	}
}
