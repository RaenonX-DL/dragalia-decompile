using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class CharacterStateCounterActionSyncBodyFormatter : IMessagePackFormatter<CharacterStateCounterActionSyncBody>
	{
		public int Serialize(ref byte[] bytes, int offset, CharacterStateCounterActionSyncBody value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public CharacterStateCounterActionSyncBody Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
