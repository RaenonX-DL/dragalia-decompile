using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class AreaTrapDungeonObjectFormatter : IMessagePackFormatter<AreaTrapDungeonObject>
	{
		public int Serialize(ref byte[] bytes, int offset, AreaTrapDungeonObject value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public AreaTrapDungeonObject Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
