using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class CombatEventReceiveEventLocationRewardResponseFormatter : IMessagePackFormatter<CombatEventReceiveEventLocationRewardResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, CombatEventReceiveEventLocationRewardResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public CombatEventReceiveEventLocationRewardResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
