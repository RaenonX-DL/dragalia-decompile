using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class DmodeBuildupServitorPassiveResponse_CommonResponseFormatter : IMessagePackFormatter<DmodeBuildupServitorPassiveResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, DmodeBuildupServitorPassiveResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DmodeBuildupServitorPassiveResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
