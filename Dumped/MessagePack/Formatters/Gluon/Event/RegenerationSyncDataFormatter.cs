using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class RegenerationSyncDataFormatter : IMessagePackFormatter<RegenerationSyncData>
	{
		public int Serialize(ref byte[] bytes, int offset, RegenerationSyncData value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public RegenerationSyncData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(RegenerationSyncData);
		}
	}
}
