using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class BuildEventReceiveDailyBonusRequestFormatter : IMessagePackFormatter<BuildEventReceiveDailyBonusRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, BuildEventReceiveDailyBonusRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public BuildEventReceiveDailyBonusRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
