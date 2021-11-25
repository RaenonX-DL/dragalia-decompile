using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class BRNotifyEventFormatter : IMessagePackFormatter<BRNotifyEvent>
	{
		public int Serialize(ref byte[] bytes, int offset, BRNotifyEvent value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public BRNotifyEvent Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
