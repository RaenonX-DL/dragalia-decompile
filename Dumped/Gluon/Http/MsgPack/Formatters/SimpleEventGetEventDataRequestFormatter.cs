using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class SimpleEventGetEventDataRequestFormatter : IMessagePackFormatter<SimpleEventGetEventDataRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, SimpleEventGetEventDataRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public SimpleEventGetEventDataRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
