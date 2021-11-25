using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class DungeonSkipStartAssignUnitRequestFormatter : IMessagePackFormatter<DungeonSkipStartAssignUnitRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, DungeonSkipStartAssignUnitRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DungeonSkipStartAssignUnitRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
