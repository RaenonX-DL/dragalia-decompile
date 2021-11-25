using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class DebugAstralItemUpdateAstralItemRequestFormatter : IMessagePackFormatter<DebugAstralItemUpdateAstralItemRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, DebugAstralItemUpdateAstralItemRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DebugAstralItemUpdateAstralItemRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
