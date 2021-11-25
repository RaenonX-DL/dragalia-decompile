using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class StatesFormatter : IMessagePackFormatter<EnemyAbility.States>
	{
		public int Serialize(ref byte[] bytes, int offset, EnemyAbility.States value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public EnemyAbility.States Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(EnemyAbility.States);
		}
	}
}
