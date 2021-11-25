using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class MissionUnlockDrillMissionGroupResponse_CommonResponseFormatter : IMessagePackFormatter<MissionUnlockDrillMissionGroupResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, MissionUnlockDrillMissionGroupResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public MissionUnlockDrillMissionGroupResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
