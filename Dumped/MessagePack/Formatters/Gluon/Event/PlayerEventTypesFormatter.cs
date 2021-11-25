using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class PlayerEventTypesFormatter : IMessagePackFormatter<PlayerEvent.PlayerEventTypes>
	{
		public int Serialize(ref byte[] bytes, int offset, PlayerEvent.PlayerEventTypes value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public PlayerEvent.PlayerEventTypes Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(PlayerEvent.PlayerEventTypes);
		}
	}
}
