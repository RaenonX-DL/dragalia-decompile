using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class GuildChatGetNewMessageListRequestFormatter : IMessagePackFormatter<GuildChatGetNewMessageListRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, GuildChatGetNewMessageListRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public GuildChatGetNewMessageListRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
