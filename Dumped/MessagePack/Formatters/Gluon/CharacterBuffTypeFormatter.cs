using Gluon;

namespace MessagePack.Formatters.Gluon
{
	public sealed class CharacterBuffTypeFormatter : IMessagePackFormatter<CharacterBuffType>
	{
		public int Serialize(ref byte[] bytes, int offset, CharacterBuffType value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public CharacterBuffType Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(CharacterBuffType);
		}
	}
}
