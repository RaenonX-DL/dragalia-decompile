using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class GuildUpdateGuildPositionTypeResponseFormatter : IMessagePackFormatter<GuildUpdateGuildPositionTypeResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, GuildUpdateGuildPositionTypeResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public GuildUpdateGuildPositionTypeResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
