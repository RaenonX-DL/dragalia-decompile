using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class CharacterStateChargeImpactSyncBodyFormatter : IMessagePackFormatter<CharacterStateChargeImpactSyncBody>
	{
		public int Serialize(ref byte[] bytes, int offset, CharacterStateChargeImpactSyncBody value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public CharacterStateChargeImpactSyncBody Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
