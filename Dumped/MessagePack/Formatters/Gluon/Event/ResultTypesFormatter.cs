using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class ResultTypesFormatter : IMessagePackFormatter<FailQuestResponse.ResultTypes>
	{
		public int Serialize(ref byte[] bytes, int offset, FailQuestResponse.ResultTypes value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public FailQuestResponse.ResultTypes Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(FailQuestResponse.ResultTypes);
		}
	}
}
