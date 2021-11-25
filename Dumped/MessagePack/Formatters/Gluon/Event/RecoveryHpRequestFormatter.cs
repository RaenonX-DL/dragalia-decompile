using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class RecoveryHpRequestFormatter : IMessagePackFormatter<RecoveryHpRequest>
	{
		public int Serialize(ref byte[] bytes, int offset, RecoveryHpRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public RecoveryHpRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
