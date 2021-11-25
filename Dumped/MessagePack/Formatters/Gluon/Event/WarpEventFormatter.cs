using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class WarpEventFormatter : IMessagePackFormatter<WarpEvent>
	{
		public int Serialize(ref byte[] bytes, int offset, WarpEvent value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public WarpEvent Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
