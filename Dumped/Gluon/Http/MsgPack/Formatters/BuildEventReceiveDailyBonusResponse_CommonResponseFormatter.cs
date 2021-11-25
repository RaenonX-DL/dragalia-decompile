using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class BuildEventReceiveDailyBonusResponse_CommonResponseFormatter : IMessagePackFormatter<BuildEventReceiveDailyBonusResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, BuildEventReceiveDailyBonusResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public BuildEventReceiveDailyBonusResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
