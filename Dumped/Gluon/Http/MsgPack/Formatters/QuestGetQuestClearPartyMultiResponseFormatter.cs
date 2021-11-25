using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class QuestGetQuestClearPartyMultiResponseFormatter : IMessagePackFormatter<QuestGetQuestClearPartyMultiResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, QuestGetQuestClearPartyMultiResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public QuestGetQuestClearPartyMultiResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
