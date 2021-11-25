using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class QuestSearchQuestClearPartyCharaMultiResponse_CommonResponseFormatter : IMessagePackFormatter<QuestSearchQuestClearPartyCharaMultiResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, QuestSearchQuestClearPartyCharaMultiResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public QuestSearchQuestClearPartyCharaMultiResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
