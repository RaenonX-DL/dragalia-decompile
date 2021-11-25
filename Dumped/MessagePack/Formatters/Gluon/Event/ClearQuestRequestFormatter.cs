using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class ClearQuestRequestFormatter : IMessagePackFormatter<ClearQuestRequest>
	{
		public int Serialize(ref byte[] bytes, int offset, ClearQuestRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public ClearQuestRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
