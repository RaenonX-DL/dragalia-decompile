using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class BattleRoyalStartRoyalMultiRequestFormatter : IMessagePackFormatter<BattleRoyalStartRoyalMultiRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, BattleRoyalStartRoyalMultiRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public BattleRoyalStartRoyalMultiRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
