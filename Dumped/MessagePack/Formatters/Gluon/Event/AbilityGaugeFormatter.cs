using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class AbilityGaugeFormatter : IMessagePackFormatter<AbilityGauge>
	{
		public int Serialize(ref byte[] bytes, int offset, AbilityGauge value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public AbilityGauge Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
