using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class RedoableSummonPreExecResponse_CommonResponseFormatter : IMessagePackFormatter<RedoableSummonPreExecResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, RedoableSummonPreExecResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public RedoableSummonPreExecResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
