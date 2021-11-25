using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class DebugInspectionRequestFormatter : IMessagePackFormatter<DebugInspectionRequest>
	{
		public int Serialize(ref byte[] bytes, int offset, DebugInspectionRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DebugInspectionRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
