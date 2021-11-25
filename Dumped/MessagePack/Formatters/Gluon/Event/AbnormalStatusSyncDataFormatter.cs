using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class AbnormalStatusSyncDataFormatter : IMessagePackFormatter<AbnormalStatusSyncData>
	{
		public int Serialize(ref byte[] bytes, int offset, AbnormalStatusSyncData value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public AbnormalStatusSyncData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(AbnormalStatusSyncData);
		}
	}
}
