using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class GrantSyncDataFormatter : IMessagePackFormatter<GrantSyncData>
	{
		public int Serialize(ref byte[] bytes, int offset, GrantSyncData value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public GrantSyncData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(GrantSyncData);
		}
	}
}
