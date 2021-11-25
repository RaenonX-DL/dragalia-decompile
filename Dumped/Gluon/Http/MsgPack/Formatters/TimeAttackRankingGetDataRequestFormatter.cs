using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class TimeAttackRankingGetDataRequestFormatter : IMessagePackFormatter<TimeAttackRankingGetDataRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, TimeAttackRankingGetDataRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public TimeAttackRankingGetDataRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
