using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class DmodeReadStoryResponse_CommonResponseFormatter : IMessagePackFormatter<DmodeReadStoryResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, DmodeReadStoryResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DmodeReadStoryResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
