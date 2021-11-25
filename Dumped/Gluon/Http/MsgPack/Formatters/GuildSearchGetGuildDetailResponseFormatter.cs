using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class GuildSearchGetGuildDetailResponseFormatter : IMessagePackFormatter<GuildSearchGetGuildDetailResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, GuildSearchGetGuildDetailResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public GuildSearchGetGuildDetailResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
