using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class EnemyAppearSyncDataFormatter : IMessagePackFormatter<EnemyAppearSyncData>
	{
		public int Serialize(ref byte[] bytes, int offset, EnemyAppearSyncData value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public EnemyAppearSyncData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(EnemyAppearSyncData);
		}
	}
}
