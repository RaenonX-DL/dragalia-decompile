using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class TreasureTradeGetListResponse_CommonResponseFormatter : IMessagePackFormatter<TreasureTradeGetListResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, TreasureTradeGetListResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public TreasureTradeGetListResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
