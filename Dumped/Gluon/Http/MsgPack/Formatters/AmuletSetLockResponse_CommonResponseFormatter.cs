using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class AmuletSetLockResponse_CommonResponseFormatter : IMessagePackFormatter<AmuletSetLockResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, AmuletSetLockResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public AmuletSetLockResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
