using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class VesselBombEventCountdownWithCoolTimeParameterFormatter : IMessagePackFormatter<VesselBombEventCountdownWithCoolTimeParameter>
	{
		public int Serialize(ref byte[] bytes, int offset, VesselBombEventCountdownWithCoolTimeParameter value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public VesselBombEventCountdownWithCoolTimeParameter Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
