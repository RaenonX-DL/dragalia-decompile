using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class MissionReceiveDailyRewardRequestFormatter : IMessagePackFormatter<MissionReceiveDailyRewardRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, MissionReceiveDailyRewardRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public MissionReceiveDailyRewardRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
