using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class RequestCounterFormatter : IMessagePackFormatter<RequestCounter>
	{
		public int Serialize(ref byte[] bytes, int offset, RequestCounter value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public RequestCounter Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
