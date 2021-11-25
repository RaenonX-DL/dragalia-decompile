using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class RemoveSyncDataFormatter : IMessagePackFormatter<RemoveSyncData>
	{
		public int Serialize(ref byte[] bytes, int offset, RemoveSyncData value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public RemoveSyncData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(RemoveSyncData);
		}
	}
}
