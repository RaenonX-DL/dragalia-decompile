using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class EventTypesFormatter : IMessagePackFormatter<ClearTimerEvent.EventTypes>
	{
		public int Serialize(ref byte[] bytes, int offset, ClearTimerEvent.EventTypes value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public ClearTimerEvent.EventTypes Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(ClearTimerEvent.EventTypes);
		}
	}
}
