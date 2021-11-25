using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class ThrowCarryReplyFormatter : IMessagePackFormatter<ThrowCarryReply>
	{
		public int Serialize(ref byte[] bytes, int offset, ThrowCarryReply value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public ThrowCarryReply Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
