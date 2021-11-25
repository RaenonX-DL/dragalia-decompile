using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class AbilityCrestTradeGetListResponse_CommonResponseFormatter : IMessagePackFormatter<AbilityCrestTradeGetListResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, AbilityCrestTradeGetListResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public AbilityCrestTradeGetListResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
