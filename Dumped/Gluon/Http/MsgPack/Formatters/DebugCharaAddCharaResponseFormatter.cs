using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class DebugCharaAddCharaResponseFormatter : IMessagePackFormatter<DebugCharaAddCharaResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, DebugCharaAddCharaResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DebugCharaAddCharaResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
