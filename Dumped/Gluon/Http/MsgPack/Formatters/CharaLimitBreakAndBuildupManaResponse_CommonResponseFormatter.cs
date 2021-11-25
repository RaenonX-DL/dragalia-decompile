using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class CharaLimitBreakAndBuildupManaResponse_CommonResponseFormatter : IMessagePackFormatter<CharaLimitBreakAndBuildupManaResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, CharaLimitBreakAndBuildupManaResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public CharaLimitBreakAndBuildupManaResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
