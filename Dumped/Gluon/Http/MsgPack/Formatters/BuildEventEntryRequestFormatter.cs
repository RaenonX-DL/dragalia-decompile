using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class BuildEventEntryRequestFormatter : IMessagePackFormatter<BuildEventEntryRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, BuildEventEntryRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public BuildEventEntryRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
