using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class SlipDamageFormatter : IMessagePackFormatter<SlipDamage>
	{
		public int Serialize(ref byte[] bytes, int offset, SlipDamage value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public SlipDamage Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
