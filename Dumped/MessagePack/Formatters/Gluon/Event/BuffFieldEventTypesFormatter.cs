using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class BuffFieldEventTypesFormatter : IMessagePackFormatter<BuffFieldEvent.BuffFieldEventTypes>
	{
		public int Serialize(ref byte[] bytes, int offset, BuffFieldEvent.BuffFieldEventTypes value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public BuffFieldEvent.BuffFieldEventTypes Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(BuffFieldEvent.BuffFieldEventTypes);
		}
	}
}
