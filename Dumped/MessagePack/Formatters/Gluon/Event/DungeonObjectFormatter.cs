using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class DungeonObjectFormatter : IMessagePackFormatter<DungeonObject>
	{
		public int Serialize(ref byte[] bytes, int offset, DungeonObject value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DungeonObject Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
