using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class BRGetItemEventFormatter : IMessagePackFormatter<BRGetItemEvent>
	{
		public int Serialize(ref byte[] bytes, int offset, BRGetItemEvent value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public BRGetItemEvent Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
