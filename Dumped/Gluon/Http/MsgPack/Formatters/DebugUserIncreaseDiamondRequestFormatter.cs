using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class DebugUserIncreaseDiamondRequestFormatter : IMessagePackFormatter<DebugUserIncreaseDiamondRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, DebugUserIncreaseDiamondRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DebugUserIncreaseDiamondRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
