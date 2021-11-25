using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class BRNotifyEventTypesFormatter : IMessagePackFormatter<BRNotifyEvent.BRNotifyEventTypes>
	{
		public int Serialize(ref byte[] bytes, int offset, BRNotifyEvent.BRNotifyEventTypes value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public BRNotifyEvent.BRNotifyEventTypes Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(BRNotifyEvent.BRNotifyEventTypes);
		}
	}
}
