using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class ThrowCarryRequestFormatter : IMessagePackFormatter<ThrowCarryRequest>
	{
		public int Serialize(ref byte[] bytes, int offset, ThrowCarryRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public ThrowCarryRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
