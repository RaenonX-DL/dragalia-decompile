using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class HostMigrationEventFormatter : IMessagePackFormatter<HostMigrationEvent>
	{
		public int Serialize(ref byte[] bytes, int offset, HostMigrationEvent value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public HostMigrationEvent Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
