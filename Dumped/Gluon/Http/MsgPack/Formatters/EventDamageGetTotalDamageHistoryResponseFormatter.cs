using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class EventDamageGetTotalDamageHistoryResponseFormatter : IMessagePackFormatter<EventDamageGetTotalDamageHistoryResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, EventDamageGetTotalDamageHistoryResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public EventDamageGetTotalDamageHistoryResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
