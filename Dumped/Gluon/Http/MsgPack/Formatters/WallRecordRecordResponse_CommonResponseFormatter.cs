using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class WallRecordRecordResponse_CommonResponseFormatter : IMessagePackFormatter<WallRecordRecordResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, WallRecordRecordResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public WallRecordRecordResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
