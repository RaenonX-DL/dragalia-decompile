using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class DeadReasonFormatter : IMessagePackFormatter<DeadReason>
	{
		public int Serialize(ref byte[] bytes, int offset, DeadReason value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DeadReason Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(DeadReason);
		}
	}
}
