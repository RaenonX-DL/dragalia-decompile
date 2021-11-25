using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class ReduceSacrificeShieldHpFormatter : IMessagePackFormatter<ReduceSacrificeShieldHp>
	{
		public int Serialize(ref byte[] bytes, int offset, ReduceSacrificeShieldHp value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public ReduceSacrificeShieldHp Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
