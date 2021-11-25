using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class AuraEventCommandDataFormatter : IMessagePackFormatter<AuraEventCommandData>
	{
		public int Serialize(ref byte[] bytes, int offset, AuraEventCommandData value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public AuraEventCommandData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(AuraEventCommandData);
		}
	}
}
