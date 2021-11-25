using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class CharacterStateChargeCancelSyncBodyFormatter : IMessagePackFormatter<CharacterStateChargeCancelSyncBody>
	{
		public int Serialize(ref byte[] bytes, int offset, CharacterStateChargeCancelSyncBody value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public CharacterStateChargeCancelSyncBody Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
