using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class BarrieredHitFormatter : IMessagePackFormatter<BarrieredHit>
	{
		public int Serialize(ref byte[] bytes, int offset, BarrieredHit value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public BarrieredHit Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
