using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class BlastDownFormatter : IMessagePackFormatter<BlastDown>
	{
		public int Serialize(ref byte[] bytes, int offset, BlastDown value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public BlastDown Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
