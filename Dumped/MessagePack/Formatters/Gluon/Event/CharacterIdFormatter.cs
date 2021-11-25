using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class CharacterIdFormatter : IMessagePackFormatter<CharacterId>
	{
		public int Serialize(ref byte[] bytes, int offset, CharacterId value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public CharacterId Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
