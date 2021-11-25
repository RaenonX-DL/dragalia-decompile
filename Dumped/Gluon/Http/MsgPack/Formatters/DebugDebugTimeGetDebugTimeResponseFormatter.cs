using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class DebugDebugTimeGetDebugTimeResponseFormatter : IMessagePackFormatter<DebugDebugTimeGetDebugTimeResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, DebugDebugTimeGetDebugTimeResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DebugDebugTimeGetDebugTimeResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
