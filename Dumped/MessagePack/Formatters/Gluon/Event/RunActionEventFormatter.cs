using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class RunActionEventFormatter : IMessagePackFormatter<RunActionEvent>
	{
		public int Serialize(ref byte[] bytes, int offset, RunActionEvent value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public RunActionEvent Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(RunActionEvent);
		}
	}
}
