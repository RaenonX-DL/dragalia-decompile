using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class DungeonSkipStartAssignUnitResponseFormatter : IMessagePackFormatter<DungeonSkipStartAssignUnitResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, DungeonSkipStartAssignUnitResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DungeonSkipStartAssignUnitResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
