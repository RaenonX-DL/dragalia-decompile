using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class SummonSummonPointTradeResponse_CommonResponseFormatter : IMessagePackFormatter<SummonSummonPointTradeResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, SummonSummonPointTradeResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public SummonSummonPointTradeResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
