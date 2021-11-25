using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class AtgenAlbumQuestPlayRecordListFormatter : IMessagePackFormatter<AtgenAlbumQuestPlayRecordList>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, AtgenAlbumQuestPlayRecordList value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public AtgenAlbumQuestPlayRecordList Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
