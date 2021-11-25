using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class TriggerAbilityFormatter : IMessagePackFormatter<TriggerAbility>
	{
		public int Serialize(ref byte[] bytes, int offset, TriggerAbility value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public TriggerAbility Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
