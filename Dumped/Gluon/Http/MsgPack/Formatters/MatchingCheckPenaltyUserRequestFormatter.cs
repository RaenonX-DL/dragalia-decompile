using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class MatchingCheckPenaltyUserRequestFormatter : IMessagePackFormatter<MatchingCheckPenaltyUserRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, MatchingCheckPenaltyUserRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public MatchingCheckPenaltyUserRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
