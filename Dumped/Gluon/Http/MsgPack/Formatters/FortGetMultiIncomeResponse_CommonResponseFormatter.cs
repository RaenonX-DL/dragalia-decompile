using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class FortGetMultiIncomeResponse_CommonResponseFormatter : IMessagePackFormatter<FortGetMultiIncomeResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, FortGetMultiIncomeResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public FortGetMultiIncomeResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
