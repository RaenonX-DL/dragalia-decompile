using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class RunActionIntParameterFormatter : IMessagePackFormatter<RunActionIntParameter>
	{
		public int Serialize(ref byte[] bytes, int offset, RunActionIntParameter value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public RunActionIntParameter Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
