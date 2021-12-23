using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class VesselBombEventResistedParameterFormatter : IMessagePackFormatter<VesselBombEventResistedParameter>
	{
		public int Serialize(ref byte[] bytes, int offset, VesselBombEventResistedParameter value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public VesselBombEventResistedParameter Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
