using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class ChangeAbilityFormatter : IMessagePackFormatter<ChangeAbility>
	{
		public int Serialize(ref byte[] bytes, int offset, ChangeAbility value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public ChangeAbility Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
