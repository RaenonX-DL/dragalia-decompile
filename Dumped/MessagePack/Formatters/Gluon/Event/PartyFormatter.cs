using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class PartyFormatter : IMessagePackFormatter<Party>
	{
		public int Serialize(ref byte[] bytes, int offset, Party value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public Party Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
