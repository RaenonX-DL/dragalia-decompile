using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class EventE02660Formatter : IMessagePackFormatter<EventE02660>
	{
		public int Serialize(ref byte[] bytes, int offset, EventE02660 value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public EventE02660 Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
