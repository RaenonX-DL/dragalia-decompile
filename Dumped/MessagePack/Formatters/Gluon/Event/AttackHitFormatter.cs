using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class AttackHitFormatter : IMessagePackFormatter<AttackHit>
	{
		public int Serialize(ref byte[] bytes, int offset, AttackHit value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public AttackHit Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
