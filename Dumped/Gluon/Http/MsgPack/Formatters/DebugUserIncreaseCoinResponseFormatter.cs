using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class DebugUserIncreaseCoinResponseFormatter : IMessagePackFormatter<DebugUserIncreaseCoinResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, DebugUserIncreaseCoinResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DebugUserIncreaseCoinResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
