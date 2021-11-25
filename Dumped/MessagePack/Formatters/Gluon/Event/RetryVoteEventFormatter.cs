using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class RetryVoteEventFormatter : IMessagePackFormatter<RetryVoteEvent>
	{
		public int Serialize(ref byte[] bytes, int offset, RetryVoteEvent value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public RetryVoteEvent Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
