using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class BindEventFormatter : IMessagePackFormatter<BindEvent>
	{
		public int Serialize(ref byte[] bytes, int offset, BindEvent value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public BindEvent Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
