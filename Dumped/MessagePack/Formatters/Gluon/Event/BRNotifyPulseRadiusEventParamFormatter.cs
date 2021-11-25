using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class BRNotifyPulseRadiusEventParamFormatter : IMessagePackFormatter<BRNotifyPulseRadiusEventParam>
	{
		public int Serialize(ref byte[] bytes, int offset, BRNotifyPulseRadiusEventParam value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public BRNotifyPulseRadiusEventParam Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
