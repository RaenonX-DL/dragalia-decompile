using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class PresentReceiveResponse_CommonResponseFormatter : IMessagePackFormatter<PresentReceiveResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, PresentReceiveResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public PresentReceiveResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
