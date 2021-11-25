using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class RegenerationFormatter : IMessagePackFormatter<Regeneration>
	{
		public int Serialize(ref byte[] bytes, int offset, Regeneration value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public Regeneration Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
