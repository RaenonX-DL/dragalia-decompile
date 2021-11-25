using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class LoginPenaltyConfirmResponse_CommonResponseFormatter : IMessagePackFormatter<LoginPenaltyConfirmResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, LoginPenaltyConfirmResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public LoginPenaltyConfirmResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
