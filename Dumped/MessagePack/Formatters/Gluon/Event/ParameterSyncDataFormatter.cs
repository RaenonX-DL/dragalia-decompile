using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class ParameterSyncDataFormatter : IMessagePackFormatter<ParameterSyncData>
	{
		public int Serialize(ref byte[] bytes, int offset, ParameterSyncData value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public ParameterSyncData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(ParameterSyncData);
		}
	}
}
