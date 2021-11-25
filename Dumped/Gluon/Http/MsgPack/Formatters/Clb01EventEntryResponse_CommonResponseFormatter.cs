using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class Clb01EventEntryResponse_CommonResponseFormatter : IMessagePackFormatter<Clb01EventEntryResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, Clb01EventEntryResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public Clb01EventEntryResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
