using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class DmodeExpeditionFinishResponse_CommonResponseFormatter : IMessagePackFormatter<DmodeExpeditionFinishResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, DmodeExpeditionFinishResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DmodeExpeditionFinishResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
