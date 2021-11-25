using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class SummonExcludeGetOddsDataRequestFormatter : IMessagePackFormatter<SummonExcludeGetOddsDataRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, SummonExcludeGetOddsDataRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public SummonExcludeGetOddsDataRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
