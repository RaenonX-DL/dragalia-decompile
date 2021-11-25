using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class DollEventFormatter : IMessagePackFormatter<DollEvent>
	{
		public int Serialize(ref byte[] bytes, int offset, DollEvent value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DollEvent Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
