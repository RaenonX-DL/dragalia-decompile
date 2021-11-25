using System;
using System.Collections.Generic;
using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class BRNotifyEventParamBaseFormatter : IMessagePackFormatter<BRNotifyEventParamBase>
	{
		private readonly Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>> typeToKeyAndJumpMap;

		private readonly Dictionary<int, int> keyToJumpMap;

		public int Serialize(ref byte[] bytes, int offset, BRNotifyEventParamBase value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public BRNotifyEventParamBase Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
