using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class BRNotifyGameEndEventParamFormatter : IMessagePackFormatter<BRNotifyGameEndEventParam>
	{
		public int Serialize(ref byte[] bytes, int offset, BRNotifyGameEndEventParam value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public BRNotifyGameEndEventParam Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
