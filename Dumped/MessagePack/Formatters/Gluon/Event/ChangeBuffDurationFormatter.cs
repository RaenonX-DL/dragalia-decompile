using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class ChangeBuffDurationFormatter : IMessagePackFormatter<ChangeBuffDuration>
	{
		public int Serialize(ref byte[] bytes, int offset, ChangeBuffDuration value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public ChangeBuffDuration Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
