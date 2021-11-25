using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class ChangeAbnormalStatusFormatter : IMessagePackFormatter<ChangeAbnormalStatus>
	{
		public int Serialize(ref byte[] bytes, int offset, ChangeAbnormalStatus value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public ChangeAbnormalStatus Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
