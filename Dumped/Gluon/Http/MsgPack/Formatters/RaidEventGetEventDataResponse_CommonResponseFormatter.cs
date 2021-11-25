using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class RaidEventGetEventDataResponse_CommonResponseFormatter : IMessagePackFormatter<RaidEventGetEventDataResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, RaidEventGetEventDataResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public RaidEventGetEventDataResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
