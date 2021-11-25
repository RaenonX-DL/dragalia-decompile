using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class GameStepEventFormatter : IMessagePackFormatter<GameStepEvent>
	{
		public int Serialize(ref byte[] bytes, int offset, GameStepEvent value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public GameStepEvent Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
