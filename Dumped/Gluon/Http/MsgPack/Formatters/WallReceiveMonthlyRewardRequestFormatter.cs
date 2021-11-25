using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class WallReceiveMonthlyRewardRequestFormatter : IMessagePackFormatter<WallReceiveMonthlyRewardRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, WallReceiveMonthlyRewardRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public WallReceiveMonthlyRewardRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
