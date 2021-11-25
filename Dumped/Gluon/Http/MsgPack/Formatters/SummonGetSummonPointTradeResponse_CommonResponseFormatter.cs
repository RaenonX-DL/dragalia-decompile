using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class SummonGetSummonPointTradeResponse_CommonResponseFormatter : IMessagePackFormatter<SummonGetSummonPointTradeResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, SummonGetSummonPointTradeResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public SummonGetSummonPointTradeResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
