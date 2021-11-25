using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class ActionPartsNotifyEventTypesFormatter : IMessagePackFormatter<ActionPartsNotifyEvent.ActionPartsNotifyEventTypes>
	{
		public int Serialize(ref byte[] bytes, int offset, ActionPartsNotifyEvent.ActionPartsNotifyEventTypes value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public ActionPartsNotifyEvent.ActionPartsNotifyEventTypes Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(ActionPartsNotifyEvent.ActionPartsNotifyEventTypes);
		}
	}
}
