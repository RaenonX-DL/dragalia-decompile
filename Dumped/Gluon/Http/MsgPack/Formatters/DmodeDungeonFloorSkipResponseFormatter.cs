using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class DmodeDungeonFloorSkipResponseFormatter : IMessagePackFormatter<DmodeDungeonFloorSkipResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, DmodeDungeonFloorSkipResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DmodeDungeonFloorSkipResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
