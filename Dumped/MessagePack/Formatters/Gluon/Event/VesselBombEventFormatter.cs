using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class VesselBombEventFormatter : IMessagePackFormatter<VesselBombEvent>
	{
		public int Serialize(ref byte[] bytes, int offset, VesselBombEvent value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public VesselBombEvent Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
