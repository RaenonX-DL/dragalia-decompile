using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class NevOptionEventTypesFormatter : IMessagePackFormatter<NevOptionEvent.NevOptionEventTypes>
	{
		public int Serialize(ref byte[] bytes, int offset, NevOptionEvent.NevOptionEventTypes value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public NevOptionEvent.NevOptionEventTypes Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(NevOptionEvent.NevOptionEventTypes);
		}
	}
}
