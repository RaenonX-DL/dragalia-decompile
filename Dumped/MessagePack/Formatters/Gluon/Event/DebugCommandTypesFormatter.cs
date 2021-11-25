using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class DebugCommandTypesFormatter : IMessagePackFormatter<DebugCommand.DebugCommandTypes>
	{
		public int Serialize(ref byte[] bytes, int offset, DebugCommand.DebugCommandTypes value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DebugCommand.DebugCommandTypes Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(DebugCommand.DebugCommandTypes);
		}
	}
}
