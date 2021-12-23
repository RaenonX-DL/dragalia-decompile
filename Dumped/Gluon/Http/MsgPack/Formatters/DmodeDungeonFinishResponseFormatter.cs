using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class DmodeDungeonFinishResponseFormatter : IMessagePackFormatter<DmodeDungeonFinishResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, DmodeDungeonFinishResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DmodeDungeonFinishResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
