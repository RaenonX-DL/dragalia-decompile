using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class EnemyDeadFormatter : IMessagePackFormatter<EnemyDead>
	{
		public int Serialize(ref byte[] bytes, int offset, EnemyDead value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public EnemyDead Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
