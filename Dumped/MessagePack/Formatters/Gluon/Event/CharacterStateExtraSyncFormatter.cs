using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class CharacterStateExtraSyncFormatter : IMessagePackFormatter<CharacterStateExtraSync>
	{
		public int Serialize(ref byte[] bytes, int offset, CharacterStateExtraSync value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public CharacterStateExtraSync Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
