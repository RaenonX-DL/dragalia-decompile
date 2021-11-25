using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class BattleRoyalRecordRoyalRecordMultiResponseFormatter : IMessagePackFormatter<BattleRoyalRecordRoyalRecordMultiResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, BattleRoyalRecordRoyalRecordMultiResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public BattleRoyalRecordRoyalRecordMultiResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
