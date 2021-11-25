using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class AbsorptionFormatter : IMessagePackFormatter<Absorption>
	{
		public int Serialize(ref byte[] bytes, int offset, Absorption value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public Absorption Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
