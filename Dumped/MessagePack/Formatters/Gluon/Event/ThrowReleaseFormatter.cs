using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class ThrowReleaseFormatter : IMessagePackFormatter<ThrowRelease>
	{
		public int Serialize(ref byte[] bytes, int offset, ThrowRelease value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public ThrowRelease Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
