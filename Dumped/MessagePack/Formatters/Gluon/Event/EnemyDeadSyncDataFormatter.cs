using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class EnemyDeadSyncDataFormatter : IMessagePackFormatter<EnemyDeadSyncData>
	{
		public int Serialize(ref byte[] bytes, int offset, EnemyDeadSyncData value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public EnemyDeadSyncData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(EnemyDeadSyncData);
		}
	}
}
