using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class EventDamageGetTotalDamageHistoryResponse_CommonResponseFormatter : IMessagePackFormatter<EventDamageGetTotalDamageHistoryResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, EventDamageGetTotalDamageHistoryResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public EventDamageGetTotalDamageHistoryResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
