using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class DebugFortUpdateFortLevelRequestFormatter : IMessagePackFormatter<DebugFortUpdateFortLevelRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, DebugFortUpdateFortLevelRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DebugFortUpdateFortLevelRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
