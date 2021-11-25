using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class MissionReceivePeriodRewardRequestFormatter : IMessagePackFormatter<MissionReceivePeriodRewardRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, MissionReceivePeriodRewardRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public MissionReceivePeriodRewardRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
