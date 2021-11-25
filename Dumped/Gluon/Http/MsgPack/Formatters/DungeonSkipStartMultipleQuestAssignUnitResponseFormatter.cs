using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class DungeonSkipStartMultipleQuestAssignUnitResponseFormatter : IMessagePackFormatter<DungeonSkipStartMultipleQuestAssignUnitResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, DungeonSkipStartMultipleQuestAssignUnitResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DungeonSkipStartMultipleQuestAssignUnitResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
