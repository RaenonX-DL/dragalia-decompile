using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class ElectrifyEventFormatter : IMessagePackFormatter<ElectrifyEvent>
	{
		public int Serialize(ref byte[] bytes, int offset, ElectrifyEvent value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public ElectrifyEvent Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
