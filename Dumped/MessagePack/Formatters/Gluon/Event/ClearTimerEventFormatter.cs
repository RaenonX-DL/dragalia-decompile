using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class ClearTimerEventFormatter : IMessagePackFormatter<ClearTimerEvent>
	{
		public int Serialize(ref byte[] bytes, int offset, ClearTimerEvent value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public ClearTimerEvent Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
