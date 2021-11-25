using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class QuestSearchQuestClearPartyCharaResponseFormatter : IMessagePackFormatter<QuestSearchQuestClearPartyCharaResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, QuestSearchQuestClearPartyCharaResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public QuestSearchQuestClearPartyCharaResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
