using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class GuildSearchIdSearchResponseFormatter : IMessagePackFormatter<GuildSearchIdSearchResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, GuildSearchIdSearchResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public GuildSearchIdSearchResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
