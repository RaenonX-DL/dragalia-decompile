using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class AtgenUserClb01EventItemListFormatter : IMessagePackFormatter<AtgenUserClb01EventItemList>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, AtgenUserClb01EventItemList value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public AtgenUserClb01EventItemList Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
