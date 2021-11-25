using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class WalkerSendGiftMultipleRequestFormatter : IMessagePackFormatter<WalkerSendGiftMultipleRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, WalkerSendGiftMultipleRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public WalkerSendGiftMultipleRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
