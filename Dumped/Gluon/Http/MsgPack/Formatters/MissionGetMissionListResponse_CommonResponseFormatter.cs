using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class MissionGetMissionListResponse_CommonResponseFormatter : IMessagePackFormatter<MissionGetMissionListResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, MissionGetMissionListResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public MissionGetMissionListResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
