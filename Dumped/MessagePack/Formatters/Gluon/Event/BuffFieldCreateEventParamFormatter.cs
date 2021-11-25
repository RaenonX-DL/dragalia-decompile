using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class BuffFieldCreateEventParamFormatter : IMessagePackFormatter<BuffFieldCreateEventParam>
	{
		public int Serialize(ref byte[] bytes, int offset, BuffFieldCreateEventParam value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public BuffFieldCreateEventParam Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
