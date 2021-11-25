using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class CartoonLatestResponse_CommonResponseFormatter : IMessagePackFormatter<CartoonLatestResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, CartoonLatestResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public CartoonLatestResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
