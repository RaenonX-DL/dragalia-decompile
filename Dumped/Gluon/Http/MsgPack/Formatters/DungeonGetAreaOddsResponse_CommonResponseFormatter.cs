using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class DungeonGetAreaOddsResponse_CommonResponseFormatter : IMessagePackFormatter<DungeonGetAreaOddsResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, DungeonGetAreaOddsResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DungeonGetAreaOddsResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
