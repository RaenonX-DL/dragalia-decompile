using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class LoginPenaltyConfirmResponseFormatter : IMessagePackFormatter<LoginPenaltyConfirmResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, LoginPenaltyConfirmResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public LoginPenaltyConfirmResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
