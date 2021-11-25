using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class CharaGetCharaUnitSetResponse_CommonResponseFormatter : IMessagePackFormatter<CharaGetCharaUnitSetResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, CharaGetCharaUnitSetResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public CharaGetCharaUnitSetResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
