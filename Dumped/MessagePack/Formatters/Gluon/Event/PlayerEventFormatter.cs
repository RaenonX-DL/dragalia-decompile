using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class PlayerEventFormatter : IMessagePackFormatter<PlayerEvent>
	{
		public int Serialize(ref byte[] bytes, int offset, PlayerEvent value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public PlayerEvent Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
