using Gluon;

namespace MessagePack.Formatters.Gluon
{
	public sealed class BattleRoyalDungeonItemFormatter : IMessagePackFormatter<BattleRoyalDungeonItem>
	{
		public int Serialize(ref byte[] bytes, int offset, BattleRoyalDungeonItem value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public BattleRoyalDungeonItem Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(BattleRoyalDungeonItem);
		}
	}
}
