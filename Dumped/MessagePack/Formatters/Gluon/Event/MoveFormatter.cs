using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class MoveFormatter : IMessagePackFormatter<Move>
	{
		public int Serialize(ref byte[] bytes, int offset, Move value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public Move Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
