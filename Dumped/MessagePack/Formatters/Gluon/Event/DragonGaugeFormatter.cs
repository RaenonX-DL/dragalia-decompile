using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class DragonGaugeFormatter : IMessagePackFormatter<DragonGauge>
	{
		public int Serialize(ref byte[] bytes, int offset, DragonGauge value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DragonGauge Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
