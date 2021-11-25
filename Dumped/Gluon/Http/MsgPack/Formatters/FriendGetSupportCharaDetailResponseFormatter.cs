using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class FriendGetSupportCharaDetailResponseFormatter : IMessagePackFormatter<FriendGetSupportCharaDetailResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, FriendGetSupportCharaDetailResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public FriendGetSupportCharaDetailResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
