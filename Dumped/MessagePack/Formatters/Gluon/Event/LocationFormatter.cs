using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class LocationFormatter : IMessagePackFormatter<Location>
	{
		public int Serialize(ref byte[] bytes, int offset, Location value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public Location Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
