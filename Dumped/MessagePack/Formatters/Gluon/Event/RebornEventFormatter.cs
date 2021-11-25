using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class RebornEventFormatter : IMessagePackFormatter<RebornEvent>
	{
		public int Serialize(ref byte[] bytes, int offset, RebornEvent value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public RebornEvent Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
