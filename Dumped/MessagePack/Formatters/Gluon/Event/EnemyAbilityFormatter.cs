using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class EnemyAbilityFormatter : IMessagePackFormatter<EnemyAbility>
	{
		public int Serialize(ref byte[] bytes, int offset, EnemyAbility value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public EnemyAbility Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
