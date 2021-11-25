using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class BlastSpFormatter : IMessagePackFormatter<BlastSp>
	{
		public int Serialize(ref byte[] bytes, int offset, BlastSp value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public BlastSp Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
