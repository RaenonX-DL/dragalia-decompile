using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class QuestGetQuestClearPartyMultiResponse_CommonResponseFormatter : IMessagePackFormatter<QuestGetQuestClearPartyMultiResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, QuestGetQuestClearPartyMultiResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public QuestGetQuestClearPartyMultiResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
