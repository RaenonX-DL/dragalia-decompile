using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class ConsumeUtpToRecoverHpEventFormatter : IMessagePackFormatter<ConsumeUtpToRecoverHpEvent>
	{
		public int Serialize(ref byte[] bytes, int offset, ConsumeUtpToRecoverHpEvent value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public ConsumeUtpToRecoverHpEvent Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
