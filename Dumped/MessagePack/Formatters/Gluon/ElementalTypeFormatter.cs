using Gluon;

namespace MessagePack.Formatters.Gluon
{
	public sealed class ElementalTypeFormatter : IMessagePackFormatter<ElementalType>
	{
		public int Serialize(ref byte[] bytes, int offset, ElementalType value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public ElementalType Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(ElementalType);
		}
	}
}
