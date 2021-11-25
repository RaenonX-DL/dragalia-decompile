using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class RunActionCompositeParameterFormatter : IMessagePackFormatter<RunActionCompositeParameter>
	{
		public int Serialize(ref byte[] bytes, int offset, RunActionCompositeParameter value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public RunActionCompositeParameter Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
