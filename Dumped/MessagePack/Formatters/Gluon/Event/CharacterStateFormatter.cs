using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class CharacterStateFormatter : IMessagePackFormatter<CharacterState>
	{
		public int Serialize(ref byte[] bytes, int offset, CharacterState value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public CharacterState Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
