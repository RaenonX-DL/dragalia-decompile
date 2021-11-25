using Gluon;

namespace MessagePack.Formatters.Gluon
{
	public sealed class AbilityConditionFormatter : IMessagePackFormatter<AbilityCondition>
	{
		public int Serialize(ref byte[] bytes, int offset, AbilityCondition value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public AbilityCondition Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(AbilityCondition);
		}
	}
}
