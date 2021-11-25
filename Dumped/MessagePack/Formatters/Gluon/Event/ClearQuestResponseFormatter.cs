using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class ClearQuestResponseFormatter : IMessagePackFormatter<ClearQuestResponse>
	{
		public int Serialize(ref byte[] bytes, int offset, ClearQuestResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public ClearQuestResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
