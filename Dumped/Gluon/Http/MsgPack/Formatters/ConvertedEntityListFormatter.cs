using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class ConvertedEntityListFormatter : IMessagePackFormatter<ConvertedEntityList>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, ConvertedEntityList value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public ConvertedEntityList Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
