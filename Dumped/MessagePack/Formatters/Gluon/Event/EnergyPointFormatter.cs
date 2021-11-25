using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class EnergyPointFormatter : IMessagePackFormatter<EnergyPoint>
	{
		public int Serialize(ref byte[] bytes, int offset, EnergyPoint value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public EnergyPoint Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
