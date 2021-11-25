using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class SimpleEventGetEventDataResponse_CommonResponseFormatter : IMessagePackFormatter<SimpleEventGetEventDataResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, SimpleEventGetEventDataResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public SimpleEventGetEventDataResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
