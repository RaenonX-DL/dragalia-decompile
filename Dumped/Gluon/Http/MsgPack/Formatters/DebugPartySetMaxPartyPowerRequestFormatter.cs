using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class DebugPartySetMaxPartyPowerRequestFormatter : IMessagePackFormatter<DebugPartySetMaxPartyPowerRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, DebugPartySetMaxPartyPowerRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DebugPartySetMaxPartyPowerRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
