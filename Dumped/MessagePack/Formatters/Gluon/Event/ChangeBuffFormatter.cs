using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class ChangeBuffFormatter : IMessagePackFormatter<ChangeBuff>
	{
		public int Serialize(ref byte[] bytes, int offset, ChangeBuff value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public ChangeBuff Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
