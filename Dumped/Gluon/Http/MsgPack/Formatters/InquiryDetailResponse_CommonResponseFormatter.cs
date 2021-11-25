using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class InquiryDetailResponse_CommonResponseFormatter : IMessagePackFormatter<InquiryDetailResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, InquiryDetailResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public InquiryDetailResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
