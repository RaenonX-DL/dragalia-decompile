using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class BuildEventReceiveDailyBonusResponseFormatter : IMessagePackFormatter<BuildEventReceiveDailyBonusResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, BuildEventReceiveDailyBonusResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public BuildEventReceiveDailyBonusResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
