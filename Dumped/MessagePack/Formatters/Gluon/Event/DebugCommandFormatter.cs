using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class DebugCommandFormatter : IMessagePackFormatter<DebugCommand>
	{
		public int Serialize(ref byte[] bytes, int offset, DebugCommand value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DebugCommand Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
