using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class FriendAllReplyDenyRequestFormatter : IMessagePackFormatter<FriendAllReplyDenyRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, FriendAllReplyDenyRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public FriendAllReplyDenyRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
