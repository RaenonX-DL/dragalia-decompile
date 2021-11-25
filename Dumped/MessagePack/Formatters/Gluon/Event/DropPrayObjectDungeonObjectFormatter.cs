using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class DropPrayObjectDungeonObjectFormatter : IMessagePackFormatter<DropPrayObjectDungeonObject>
	{
		public int Serialize(ref byte[] bytes, int offset, DropPrayObjectDungeonObject value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DropPrayObjectDungeonObject Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
