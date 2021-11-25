using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class RepeatEndResponse_CommonResponseFormatter : IMessagePackFormatter<RepeatEndResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, RepeatEndResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public RepeatEndResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
