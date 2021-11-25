using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class FriendSetSupportCharaResponseFormatter : IMessagePackFormatter<FriendSetSupportCharaResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, FriendSetSupportCharaResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public FriendSetSupportCharaResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
