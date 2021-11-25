using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class InquiryAggregationRequestFormatter : IMessagePackFormatter<InquiryAggregationRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, InquiryAggregationRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public InquiryAggregationRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
