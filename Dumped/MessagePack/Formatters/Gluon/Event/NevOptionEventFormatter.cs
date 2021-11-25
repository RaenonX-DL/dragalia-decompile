using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class NevOptionEventFormatter : IMessagePackFormatter<NevOptionEvent>
	{
		public int Serialize(ref byte[] bytes, int offset, NevOptionEvent value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public NevOptionEvent Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
