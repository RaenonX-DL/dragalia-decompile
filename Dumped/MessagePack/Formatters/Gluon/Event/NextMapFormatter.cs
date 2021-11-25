using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class NextMapFormatter : IMessagePackFormatter<NextMap>
	{
		public int Serialize(ref byte[] bytes, int offset, NextMap value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public NextMap Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
