using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class PatternTypesFormatter : IMessagePackFormatter<BRCreateItemEvent.PatternTypes>
	{
		public int Serialize(ref byte[] bytes, int offset, BRCreateItemEvent.PatternTypes value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public BRCreateItemEvent.PatternTypes Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(BRCreateItemEvent.PatternTypes);
		}
	}
}
