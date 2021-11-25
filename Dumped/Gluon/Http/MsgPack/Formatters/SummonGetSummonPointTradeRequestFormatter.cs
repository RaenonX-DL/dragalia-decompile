using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class SummonGetSummonPointTradeRequestFormatter : IMessagePackFormatter<SummonGetSummonPointTradeRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, SummonGetSummonPointTradeRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public SummonGetSummonPointTradeRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
