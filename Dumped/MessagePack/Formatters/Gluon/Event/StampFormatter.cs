using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class StampFormatter : IMessagePackFormatter<Stamp>
	{
		public int Serialize(ref byte[] bytes, int offset, Stamp value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public Stamp Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
