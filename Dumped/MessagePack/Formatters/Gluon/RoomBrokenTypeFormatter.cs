using Gluon;

namespace MessagePack.Formatters.Gluon
{
	public sealed class RoomBrokenTypeFormatter : IMessagePackFormatter<RoomBrokenType>
	{
		public int Serialize(ref byte[] bytes, int offset, RoomBrokenType value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public RoomBrokenType Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(RoomBrokenType);
		}
	}
}
