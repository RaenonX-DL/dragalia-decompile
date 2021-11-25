using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class RequestGuardCounterFormatter : IMessagePackFormatter<RequestGuardCounter>
	{
		public int Serialize(ref byte[] bytes, int offset, RequestGuardCounter value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public RequestGuardCounter Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
