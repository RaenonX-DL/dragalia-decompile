using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class OptionSetOptionResponse_CommonResponseFormatter : IMessagePackFormatter<OptionSetOptionResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, OptionSetOptionResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public OptionSetOptionResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
