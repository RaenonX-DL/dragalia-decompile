using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class CharacterSpecialStateFormatter : IMessagePackFormatter<CharacterSpecialState>
	{
		public int Serialize(ref byte[] bytes, int offset, CharacterSpecialState value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public CharacterSpecialState Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
