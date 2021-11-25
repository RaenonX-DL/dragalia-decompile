using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class FailTypesFormatter : IMessagePackFormatter<FailQuestRequest.FailTypes>
	{
		public int Serialize(ref byte[] bytes, int offset, FailQuestRequest.FailTypes value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public FailQuestRequest.FailTypes Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(FailQuestRequest.FailTypes);
		}
	}
}
