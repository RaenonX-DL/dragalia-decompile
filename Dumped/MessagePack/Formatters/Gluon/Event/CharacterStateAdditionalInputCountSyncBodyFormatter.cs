using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class CharacterStateAdditionalInputCountSyncBodyFormatter : IMessagePackFormatter<CharacterStateAdditionalInputCountSyncBody>
	{
		public int Serialize(ref byte[] bytes, int offset, CharacterStateAdditionalInputCountSyncBody value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public CharacterStateAdditionalInputCountSyncBody Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
