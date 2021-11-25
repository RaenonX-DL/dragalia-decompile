using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class BRItemParamFormatter : IMessagePackFormatter<BRItemParam>
	{
		public int Serialize(ref byte[] bytes, int offset, BRItemParam value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public BRItemParam Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(BRItemParam);
		}
	}
}
