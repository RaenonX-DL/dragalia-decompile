using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class CharacterDataFormatter : IMessagePackFormatter<CharacterData>
	{
		public int Serialize(ref byte[] bytes, int offset, CharacterData value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public CharacterData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
