using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class BRCreateItemEventFormatter : IMessagePackFormatter<BRCreateItemEvent>
	{
		public int Serialize(ref byte[] bytes, int offset, BRCreateItemEvent value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public BRCreateItemEvent Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
