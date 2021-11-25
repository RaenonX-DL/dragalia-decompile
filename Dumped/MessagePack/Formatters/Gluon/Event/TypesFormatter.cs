using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class TypesFormatter : IMessagePackFormatter<BindEvent.Types>
	{
		public int Serialize(ref byte[] bytes, int offset, BindEvent.Types value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public BindEvent.Types Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(BindEvent.Types);
		}
	}
}
