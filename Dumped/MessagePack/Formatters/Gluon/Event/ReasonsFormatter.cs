using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class ReasonsFormatter : IMessagePackFormatter<WillLeave.Reasons>
	{
		public int Serialize(ref byte[] bytes, int offset, WillLeave.Reasons value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public WillLeave.Reasons Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(WillLeave.Reasons);
		}
	}
}
