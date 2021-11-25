using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class RoomEntryCondition_ObjectiveFormatter : IMessagePackFormatter<RoomEntryCondition.Objective>
	{
		public int Serialize(ref byte[] bytes, int offset, RoomEntryCondition.Objective value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public RoomEntryCondition.Objective Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(RoomEntryCondition.Objective);
		}
	}
}
