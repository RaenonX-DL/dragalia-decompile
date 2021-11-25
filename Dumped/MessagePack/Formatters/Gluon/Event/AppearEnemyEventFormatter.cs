using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class AppearEnemyEventFormatter : IMessagePackFormatter<AppearEnemyEvent>
	{
		public int Serialize(ref byte[] bytes, int offset, AppearEnemyEvent value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public AppearEnemyEvent Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
