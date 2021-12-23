using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class DebugDmodeUpdateDmodeServitorPassiveMaxRequestFormatter : IMessagePackFormatter<DebugDmodeUpdateDmodeServitorPassiveMaxRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, DebugDmodeUpdateDmodeServitorPassiveMaxRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DebugDmodeUpdateDmodeServitorPassiveMaxRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
