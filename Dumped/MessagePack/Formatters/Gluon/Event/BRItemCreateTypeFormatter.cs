using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class BRItemCreateTypeFormatter : IMessagePackFormatter<BRItemId.BRItemCreateType>
	{
		public int Serialize(ref byte[] bytes, int offset, BRItemId.BRItemCreateType value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public BRItemId.BRItemCreateType Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(BRItemId.BRItemCreateType);
		}
	}
}
