using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class ChargeFormatter : IMessagePackFormatter<Charge>
	{
		public int Serialize(ref byte[] bytes, int offset, Charge value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public Charge Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
