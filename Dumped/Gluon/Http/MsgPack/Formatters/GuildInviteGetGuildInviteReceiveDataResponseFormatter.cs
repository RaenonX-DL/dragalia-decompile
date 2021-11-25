using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class GuildInviteGetGuildInviteReceiveDataResponseFormatter : IMessagePackFormatter<GuildInviteGetGuildInviteReceiveDataResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, GuildInviteGetGuildInviteReceiveDataResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public GuildInviteGetGuildInviteReceiveDataResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
