using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class RunActionParameterElementFormatter : IMessagePackFormatter<RunActionParameterElement>
	{
		public int Serialize(ref byte[] bytes, int offset, RunActionParameterElement value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public RunActionParameterElement Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(RunActionParameterElement);
		}
	}
}
