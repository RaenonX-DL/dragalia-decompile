using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class LotteryLotteryExecResponse_CommonResponseFormatter : IMessagePackFormatter<LotteryLotteryExecResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, LotteryLotteryExecResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public LotteryLotteryExecResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
