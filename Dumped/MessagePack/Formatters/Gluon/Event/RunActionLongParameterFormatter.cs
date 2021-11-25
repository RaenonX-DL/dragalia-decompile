using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class RunActionLongParameterFormatter : IMessagePackFormatter<RunActionLongParameter>
	{
		public int Serialize(ref byte[] bytes, int offset, RunActionLongParameter value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public RunActionLongParameter Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
