using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class BRNotifyLookingCharaParamFormatter : IMessagePackFormatter<BRNotifyLookingCharaParam>
	{
		public int Serialize(ref byte[] bytes, int offset, BRNotifyLookingCharaParam value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public BRNotifyLookingCharaParam Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
