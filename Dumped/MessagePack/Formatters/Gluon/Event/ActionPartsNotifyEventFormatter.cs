using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class ActionPartsNotifyEventFormatter : IMessagePackFormatter<ActionPartsNotifyEvent>
	{
		public int Serialize(ref byte[] bytes, int offset, ActionPartsNotifyEvent value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public ActionPartsNotifyEvent Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
