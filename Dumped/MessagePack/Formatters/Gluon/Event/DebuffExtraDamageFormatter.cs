using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class DebuffExtraDamageFormatter : IMessagePackFormatter<DebuffExtraDamage>
	{
		public int Serialize(ref byte[] bytes, int offset, DebuffExtraDamage value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DebuffExtraDamage Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
