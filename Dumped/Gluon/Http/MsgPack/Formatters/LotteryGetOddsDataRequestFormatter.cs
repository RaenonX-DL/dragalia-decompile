using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class LotteryGetOddsDataRequestFormatter : IMessagePackFormatter<LotteryGetOddsDataRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, LotteryGetOddsDataRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public LotteryGetOddsDataRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
