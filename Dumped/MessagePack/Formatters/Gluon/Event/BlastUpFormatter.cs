using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class BlastUpFormatter : IMessagePackFormatter<BlastUp>
	{
		public int Serialize(ref byte[] bytes, int offset, BlastUp value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public BlastUp Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
