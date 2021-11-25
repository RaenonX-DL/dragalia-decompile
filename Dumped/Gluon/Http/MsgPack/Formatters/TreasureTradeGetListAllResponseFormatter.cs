using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class TreasureTradeGetListAllResponseFormatter : IMessagePackFormatter<TreasureTradeGetListAllResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, TreasureTradeGetListAllResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public TreasureTradeGetListAllResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
