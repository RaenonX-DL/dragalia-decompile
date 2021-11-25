using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class TargetPartsFormatter : IMessagePackFormatter<TargetParts>
	{
		public int Serialize(ref byte[] bytes, int offset, TargetParts value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public TargetParts Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
