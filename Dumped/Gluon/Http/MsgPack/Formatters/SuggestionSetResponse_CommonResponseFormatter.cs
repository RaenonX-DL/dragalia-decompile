using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class SuggestionSetResponse_CommonResponseFormatter : IMessagePackFormatter<SuggestionSetResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, SuggestionSetResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public SuggestionSetResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
