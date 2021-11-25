using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class GuildInviteInviteCancelResponseFormatter : IMessagePackFormatter<GuildInviteInviteCancelResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, GuildInviteInviteCancelResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public GuildInviteInviteCancelResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
