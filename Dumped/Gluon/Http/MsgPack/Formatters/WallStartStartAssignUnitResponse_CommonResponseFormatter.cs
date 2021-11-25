using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class WallStartStartAssignUnitResponse_CommonResponseFormatter : IMessagePackFormatter<WallStartStartAssignUnitResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, WallStartStartAssignUnitResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public WallStartStartAssignUnitResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
