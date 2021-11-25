using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class MultiWeakEventTypesFormatter : IMessagePackFormatter<MultiWeakEvent.MultiWeakEventTypes>
	{
		public int Serialize(ref byte[] bytes, int offset, MultiWeakEvent.MultiWeakEventTypes value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public MultiWeakEvent.MultiWeakEventTypes Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(MultiWeakEvent.MultiWeakEventTypes);
		}
	}
}
