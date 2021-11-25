using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class TransformCharacterFormatter : IMessagePackFormatter<TransformCharacter>
	{
		public int Serialize(ref byte[] bytes, int offset, TransformCharacter value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public TransformCharacter Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
