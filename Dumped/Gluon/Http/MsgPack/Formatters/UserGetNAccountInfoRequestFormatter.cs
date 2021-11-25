using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class UserGetNAccountInfoRequestFormatter : IMessagePackFormatter<UserGetNAccountInfoRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, UserGetNAccountInfoRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public UserGetNAccountInfoRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
