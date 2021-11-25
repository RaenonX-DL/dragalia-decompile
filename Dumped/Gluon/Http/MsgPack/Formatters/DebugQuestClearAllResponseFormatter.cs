using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class DebugQuestClearAllResponseFormatter : IMessagePackFormatter<DebugQuestClearAllResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, DebugQuestClearAllResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DebugQuestClearAllResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
