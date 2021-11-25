using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class AuraEventCommandTypeFormatter : IMessagePackFormatter<AuraEventCommandType>
	{
		public int Serialize(ref byte[] bytes, int offset, AuraEventCommandType value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public AuraEventCommandType Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(AuraEventCommandType);
		}
	}
}
