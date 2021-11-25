using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class DebugInspectionResponseFormatter : IMessagePackFormatter<DebugInspectionResponse>
	{
		public int Serialize(ref byte[] bytes, int offset, DebugInspectionResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DebugInspectionResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
