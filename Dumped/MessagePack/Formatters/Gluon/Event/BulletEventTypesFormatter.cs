using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class BulletEventTypesFormatter : IMessagePackFormatter<BulletEvent.BulletEventTypes>
	{
		public int Serialize(ref byte[] bytes, int offset, BulletEvent.BulletEventTypes value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public BulletEvent.BulletEventTypes Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(BulletEvent.BulletEventTypes);
		}
	}
}
