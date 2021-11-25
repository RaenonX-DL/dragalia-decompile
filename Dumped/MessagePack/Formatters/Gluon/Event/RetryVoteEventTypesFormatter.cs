using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class RetryVoteEventTypesFormatter : IMessagePackFormatter<RetryVoteEvent.RetryVoteEventTypes>
	{
		public int Serialize(ref byte[] bytes, int offset, RetryVoteEvent.RetryVoteEventTypes value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public RetryVoteEvent.RetryVoteEventTypes Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(RetryVoteEvent.RetryVoteEventTypes);
		}
	}
}
