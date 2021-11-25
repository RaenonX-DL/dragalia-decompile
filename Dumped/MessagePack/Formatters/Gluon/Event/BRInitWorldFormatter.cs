using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class BRInitWorldFormatter : IMessagePackFormatter<BRInitWorld>
	{
		public int Serialize(ref byte[] bytes, int offset, BRInitWorld value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public BRInitWorld Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
