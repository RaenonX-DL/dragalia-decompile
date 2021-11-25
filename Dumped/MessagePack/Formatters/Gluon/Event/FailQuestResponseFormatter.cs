using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class FailQuestResponseFormatter : IMessagePackFormatter<FailQuestResponse>
	{
		public int Serialize(ref byte[] bytes, int offset, FailQuestResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public FailQuestResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
