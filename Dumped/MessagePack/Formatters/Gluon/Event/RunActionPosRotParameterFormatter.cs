using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class RunActionPosRotParameterFormatter : IMessagePackFormatter<RunActionPosRotParameter>
	{
		public int Serialize(ref byte[] bytes, int offset, RunActionPosRotParameter value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public RunActionPosRotParameter Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
