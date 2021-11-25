using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class UnifiedParameterSyncDataFormatter : IMessagePackFormatter<UnifiedParameterSyncData>
	{
		public int Serialize(ref byte[] bytes, int offset, UnifiedParameterSyncData value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public UnifiedParameterSyncData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(UnifiedParameterSyncData);
		}
	}
}
