using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class AreaTrapEventTypeFormatter : IMessagePackFormatter<AreaTrapDungeonObject.AreaTrapEventType>
	{
		public int Serialize(ref byte[] bytes, int offset, AreaTrapDungeonObject.AreaTrapEventType value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public AreaTrapDungeonObject.AreaTrapEventType Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(AreaTrapDungeonObject.AreaTrapEventType);
		}
	}
}
