using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class FailQuestRequestFormatter : IMessagePackFormatter<FailQuestRequest>
	{
		public int Serialize(ref byte[] bytes, int offset, FailQuestRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public FailQuestRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
