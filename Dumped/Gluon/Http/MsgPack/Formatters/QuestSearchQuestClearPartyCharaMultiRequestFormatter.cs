using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class QuestSearchQuestClearPartyCharaMultiRequestFormatter : IMessagePackFormatter<QuestSearchQuestClearPartyCharaMultiRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, QuestSearchQuestClearPartyCharaMultiRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public QuestSearchQuestClearPartyCharaMultiRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
