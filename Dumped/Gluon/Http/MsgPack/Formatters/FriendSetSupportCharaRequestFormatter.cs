using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class FriendSetSupportCharaRequestFormatter : IMessagePackFormatter<FriendSetSupportCharaRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, FriendSetSupportCharaRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public FriendSetSupportCharaRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
