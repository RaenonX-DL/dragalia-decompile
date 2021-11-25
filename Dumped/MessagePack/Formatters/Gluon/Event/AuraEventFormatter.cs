using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class AuraEventFormatter : IMessagePackFormatter<AuraEvent>
	{
		public int Serialize(ref byte[] bytes, int offset, AuraEvent value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public AuraEvent Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
