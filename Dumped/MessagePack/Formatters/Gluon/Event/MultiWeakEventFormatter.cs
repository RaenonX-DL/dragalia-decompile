using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class MultiWeakEventFormatter : IMessagePackFormatter<MultiWeakEvent>
	{
		public int Serialize(ref byte[] bytes, int offset, MultiWeakEvent value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public MultiWeakEvent Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
