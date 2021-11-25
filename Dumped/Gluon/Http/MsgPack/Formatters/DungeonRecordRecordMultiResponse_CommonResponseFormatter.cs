using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class DungeonRecordRecordMultiResponse_CommonResponseFormatter : IMessagePackFormatter<DungeonRecordRecordMultiResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, DungeonRecordRecordMultiResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DungeonRecordRecordMultiResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
