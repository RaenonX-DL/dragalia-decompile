using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class BuffFieldEventFormatter : IMessagePackFormatter<BuffFieldEvent>
	{
		public int Serialize(ref byte[] bytes, int offset, BuffFieldEvent value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public BuffFieldEvent Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
