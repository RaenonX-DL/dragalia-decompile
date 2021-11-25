using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class WarpEventTypesFormatter : IMessagePackFormatter<WarpEvent.WarpEventTypes>
	{
		public int Serialize(ref byte[] bytes, int offset, WarpEvent.WarpEventTypes value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public WarpEvent.WarpEventTypes Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(WarpEvent.WarpEventTypes);
		}
	}
}
