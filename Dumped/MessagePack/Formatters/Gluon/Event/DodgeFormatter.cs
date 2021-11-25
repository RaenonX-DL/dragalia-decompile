using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class DodgeFormatter : IMessagePackFormatter<Dodge>
	{
		public int Serialize(ref byte[] bytes, int offset, Dodge value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public Dodge Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
