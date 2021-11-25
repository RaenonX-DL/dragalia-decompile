using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class AbilityCrestBuildupPieceRequestFormatter : IMessagePackFormatter<AbilityCrestBuildupPieceRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, AbilityCrestBuildupPieceRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public AbilityCrestBuildupPieceRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
