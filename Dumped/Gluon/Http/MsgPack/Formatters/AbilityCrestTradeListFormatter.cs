using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class AbilityCrestTradeListFormatter : IMessagePackFormatter<AbilityCrestTradeList>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, AbilityCrestTradeList value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public AbilityCrestTradeList Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
