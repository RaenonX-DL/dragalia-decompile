using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class UserRecoverStaminaByStoneResponse_CommonResponseFormatter : IMessagePackFormatter<UserRecoverStaminaByStoneResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, UserRecoverStaminaByStoneResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public UserRecoverStaminaByStoneResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
