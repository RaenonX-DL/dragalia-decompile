using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class UpdateNamechangeResponse_CommonResponseFormatter : IMessagePackFormatter<UpdateNamechangeResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, UpdateNamechangeResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public UpdateNamechangeResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
