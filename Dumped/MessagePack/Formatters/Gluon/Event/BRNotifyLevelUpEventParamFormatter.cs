using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class BRNotifyLevelUpEventParamFormatter : IMessagePackFormatter<BRNotifyLevelUpEventParam>
	{
		public int Serialize(ref byte[] bytes, int offset, BRNotifyLevelUpEventParam value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public BRNotifyLevelUpEventParam Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
