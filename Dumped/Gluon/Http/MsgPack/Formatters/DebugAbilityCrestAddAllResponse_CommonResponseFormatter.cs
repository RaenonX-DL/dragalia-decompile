using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class DebugAbilityCrestAddAllResponse_CommonResponseFormatter : IMessagePackFormatter<DebugAbilityCrestAddAllResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, DebugAbilityCrestAddAllResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DebugAbilityCrestAddAllResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
