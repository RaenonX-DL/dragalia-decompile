using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class AmuletResetPlusCountResponse_CommonResponseFormatter : IMessagePackFormatter<AmuletResetPlusCountResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, AmuletResetPlusCountResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public AmuletResetPlusCountResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
