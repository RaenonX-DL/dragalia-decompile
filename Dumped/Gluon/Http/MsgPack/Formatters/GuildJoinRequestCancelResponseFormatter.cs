using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class GuildJoinRequestCancelResponseFormatter : IMessagePackFormatter<GuildJoinRequestCancelResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, GuildJoinRequestCancelResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public GuildJoinRequestCancelResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
