using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class RunActionParameterSetFormatter : IMessagePackFormatter<RunActionParameterSet>
	{
		public int Serialize(ref byte[] bytes, int offset, RunActionParameterSet value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public RunActionParameterSet Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
