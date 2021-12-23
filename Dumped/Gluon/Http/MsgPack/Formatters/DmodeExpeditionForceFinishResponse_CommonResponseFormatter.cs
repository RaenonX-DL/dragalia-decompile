using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class DmodeExpeditionForceFinishResponse_CommonResponseFormatter : IMessagePackFormatter<DmodeExpeditionForceFinishResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, DmodeExpeditionForceFinishResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DmodeExpeditionForceFinishResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
