using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class EventD00562Formatter : IMessagePackFormatter<EventD00562>
	{
		public int Serialize(ref byte[] bytes, int offset, EventD00562 value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public EventD00562 Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
