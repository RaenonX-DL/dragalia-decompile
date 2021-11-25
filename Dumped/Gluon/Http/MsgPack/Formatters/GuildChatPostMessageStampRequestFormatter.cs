using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class GuildChatPostMessageStampRequestFormatter : IMessagePackFormatter<GuildChatPostMessageStampRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, GuildChatPostMessageStampRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public GuildChatPostMessageStampRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
