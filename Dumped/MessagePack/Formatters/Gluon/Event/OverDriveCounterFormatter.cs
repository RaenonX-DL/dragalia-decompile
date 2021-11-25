using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class OverDriveCounterFormatter : IMessagePackFormatter<OverDriveCounter>
	{
		public int Serialize(ref byte[] bytes, int offset, OverDriveCounter value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public OverDriveCounter Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
