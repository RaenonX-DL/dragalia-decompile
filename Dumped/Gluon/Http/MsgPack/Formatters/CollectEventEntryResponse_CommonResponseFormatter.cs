using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class CollectEventEntryResponse_CommonResponseFormatter : IMessagePackFormatter<CollectEventEntryResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, CollectEventEntryResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public CollectEventEntryResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
