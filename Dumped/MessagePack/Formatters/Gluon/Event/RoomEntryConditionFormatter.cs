using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class RoomEntryConditionFormatter : IMessagePackFormatter<RoomEntryCondition>
	{
		public int Serialize(ref byte[] bytes, int offset, RoomEntryCondition value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public RoomEntryCondition Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
