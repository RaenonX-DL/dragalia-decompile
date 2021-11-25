using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class WillLeaveFormatter : IMessagePackFormatter<WillLeave>
	{
		public int Serialize(ref byte[] bytes, int offset, WillLeave value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public WillLeave Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
