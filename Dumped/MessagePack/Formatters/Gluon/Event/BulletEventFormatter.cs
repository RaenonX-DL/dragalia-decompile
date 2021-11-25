using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class BulletEventFormatter : IMessagePackFormatter<BulletEvent>
	{
		public int Serialize(ref byte[] bytes, int offset, BulletEvent value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public BulletEvent Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
