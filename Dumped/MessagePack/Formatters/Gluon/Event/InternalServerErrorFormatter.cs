using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class InternalServerErrorFormatter : IMessagePackFormatter<InternalServerError>
	{
		public int Serialize(ref byte[] bytes, int offset, InternalServerError value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public InternalServerError Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
