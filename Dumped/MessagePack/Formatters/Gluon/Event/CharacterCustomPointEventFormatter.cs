using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class CharacterCustomPointEventFormatter : IMessagePackFormatter<CharacterCustomPointEvent>
	{
		public int Serialize(ref byte[] bytes, int offset, CharacterCustomPointEvent value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public CharacterCustomPointEvent Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
