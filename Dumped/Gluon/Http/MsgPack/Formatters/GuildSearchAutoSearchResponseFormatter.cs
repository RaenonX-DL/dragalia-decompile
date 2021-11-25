using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class GuildSearchAutoSearchResponseFormatter : IMessagePackFormatter<GuildSearchAutoSearchResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, GuildSearchAutoSearchResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public GuildSearchAutoSearchResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
