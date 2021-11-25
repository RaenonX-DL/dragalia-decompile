using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class DragonSendGiftResponse_CommonResponseFormatter : IMessagePackFormatter<DragonSendGiftResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, DragonSendGiftResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DragonSendGiftResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
