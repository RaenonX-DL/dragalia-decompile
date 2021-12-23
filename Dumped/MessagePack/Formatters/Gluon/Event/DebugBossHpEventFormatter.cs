using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class DebugBossHpEventFormatter : IMessagePackFormatter<DebugBossHpEvent>
	{
		public int Serialize(ref byte[] bytes, int offset, DebugBossHpEvent value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DebugBossHpEvent Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
