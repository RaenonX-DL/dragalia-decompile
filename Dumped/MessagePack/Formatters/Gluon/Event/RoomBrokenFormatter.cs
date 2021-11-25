using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class RoomBrokenFormatter : IMessagePackFormatter<RoomBroken>
	{
		public int Serialize(ref byte[] bytes, int offset, RoomBroken value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public RoomBroken Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
