using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class DropPrayObjectEventTypeFormatter : IMessagePackFormatter<DropPrayObjectDungeonObject.DropPrayObjectEventType>
	{
		public int Serialize(ref byte[] bytes, int offset, DropPrayObjectDungeonObject.DropPrayObjectEventType value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DropPrayObjectDungeonObject.DropPrayObjectEventType Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(DropPrayObjectDungeonObject.DropPrayObjectEventType);
		}
	}
}
