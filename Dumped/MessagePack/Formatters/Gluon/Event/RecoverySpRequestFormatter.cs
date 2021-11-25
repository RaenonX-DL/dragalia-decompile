using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class RecoverySpRequestFormatter : IMessagePackFormatter<RecoverySpRequest>
	{
		public int Serialize(ref byte[] bytes, int offset, RecoverySpRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public RecoverySpRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
