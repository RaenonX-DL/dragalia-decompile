using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class RequestTypesFormatter : IMessagePackFormatter<DebugInspectionRequest.RequestTypes>
	{
		public int Serialize(ref byte[] bytes, int offset, DebugInspectionRequest.RequestTypes value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DebugInspectionRequest.RequestTypes Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(DebugInspectionRequest.RequestTypes);
		}
	}
}
