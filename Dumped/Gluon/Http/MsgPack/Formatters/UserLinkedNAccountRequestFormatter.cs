using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class UserLinkedNAccountRequestFormatter : IMessagePackFormatter<UserLinkedNAccountRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, UserLinkedNAccountRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public UserLinkedNAccountRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
