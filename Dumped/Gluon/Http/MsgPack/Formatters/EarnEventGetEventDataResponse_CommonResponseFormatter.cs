using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class EarnEventGetEventDataResponse_CommonResponseFormatter : IMessagePackFormatter<EarnEventGetEventDataResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, EarnEventGetEventDataResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public EarnEventGetEventDataResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
