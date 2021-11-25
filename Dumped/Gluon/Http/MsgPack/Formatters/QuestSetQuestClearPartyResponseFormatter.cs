using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class QuestSetQuestClearPartyResponseFormatter : IMessagePackFormatter<QuestSetQuestClearPartyResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, QuestSetQuestClearPartyResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public QuestSetQuestClearPartyResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
