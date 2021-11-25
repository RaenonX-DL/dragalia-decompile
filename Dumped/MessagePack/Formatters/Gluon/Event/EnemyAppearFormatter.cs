using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class EnemyAppearFormatter : IMessagePackFormatter<EnemyAppear>
	{
		public int Serialize(ref byte[] bytes, int offset, EnemyAppear value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public EnemyAppear Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
