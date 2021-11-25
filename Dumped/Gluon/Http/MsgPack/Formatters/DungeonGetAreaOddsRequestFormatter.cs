using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class DungeonGetAreaOddsRequestFormatter : IMessagePackFormatter<DungeonGetAreaOddsRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, DungeonGetAreaOddsRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DungeonGetAreaOddsRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
