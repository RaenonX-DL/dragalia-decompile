using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class KnockBackFormatter : IMessagePackFormatter<KnockBack>
	{
		public int Serialize(ref byte[] bytes, int offset, KnockBack value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public KnockBack Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
