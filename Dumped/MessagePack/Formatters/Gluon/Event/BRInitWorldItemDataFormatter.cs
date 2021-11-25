using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class BRInitWorldItemDataFormatter : IMessagePackFormatter<BRInitWorldItemData>
	{
		public int Serialize(ref byte[] bytes, int offset, BRInitWorldItemData value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public BRInitWorldItemData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(BRInitWorldItemData);
		}
	}
}
