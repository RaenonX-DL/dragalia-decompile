using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class RunActionRandomParameterFormatter : IMessagePackFormatter<RunActionRandomParameter>
	{
		public int Serialize(ref byte[] bytes, int offset, RunActionRandomParameter value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public RunActionRandomParameter Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
