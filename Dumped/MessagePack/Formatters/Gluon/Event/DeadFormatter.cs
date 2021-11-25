using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class DeadFormatter : IMessagePackFormatter<Dead>
	{
		public int Serialize(ref byte[] bytes, int offset, Dead value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public Dead Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
