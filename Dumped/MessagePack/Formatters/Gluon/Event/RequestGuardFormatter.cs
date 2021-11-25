using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class RequestGuardFormatter : IMessagePackFormatter<RequestGuard>
	{
		public int Serialize(ref byte[] bytes, int offset, RequestGuard value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public RequestGuard Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
