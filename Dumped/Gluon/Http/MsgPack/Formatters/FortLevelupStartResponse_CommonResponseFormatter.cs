using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class FortLevelupStartResponse_CommonResponseFormatter : IMessagePackFormatter<FortLevelupStartResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, FortLevelupStartResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public FortLevelupStartResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
