using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class BRNotifyExtraParamFormatter : IMessagePackFormatter<BRNotifyExtraParam>
	{
		public int Serialize(ref byte[] bytes, int offset, BRNotifyExtraParam value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public BRNotifyExtraParam Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
