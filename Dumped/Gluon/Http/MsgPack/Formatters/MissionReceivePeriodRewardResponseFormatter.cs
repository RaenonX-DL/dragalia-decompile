using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class MissionReceivePeriodRewardResponseFormatter : IMessagePackFormatter<MissionReceivePeriodRewardResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, MissionReceivePeriodRewardResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public MissionReceivePeriodRewardResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
