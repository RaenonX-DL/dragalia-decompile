using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class ToolReauthResponse_CommonResponseFormatter : IMessagePackFormatter<ToolReauthResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, ToolReauthResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public ToolReauthResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
