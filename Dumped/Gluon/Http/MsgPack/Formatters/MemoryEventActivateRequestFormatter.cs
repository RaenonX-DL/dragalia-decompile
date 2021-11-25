using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class MemoryEventActivateRequestFormatter : IMessagePackFormatter<MemoryEventActivateRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, MemoryEventActivateRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public MemoryEventActivateRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
