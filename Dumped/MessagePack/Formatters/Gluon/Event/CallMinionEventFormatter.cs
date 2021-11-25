using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class CallMinionEventFormatter : IMessagePackFormatter<CallMinionEvent>
	{
		public int Serialize(ref byte[] bytes, int offset, CallMinionEvent value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public CallMinionEvent Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
