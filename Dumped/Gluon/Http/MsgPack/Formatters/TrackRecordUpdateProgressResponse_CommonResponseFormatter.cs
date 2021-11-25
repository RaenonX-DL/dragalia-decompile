using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class TrackRecordUpdateProgressResponse_CommonResponseFormatter : IMessagePackFormatter<TrackRecordUpdateProgressResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, TrackRecordUpdateProgressResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public TrackRecordUpdateProgressResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
