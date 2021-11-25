using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class AtgenSupportAmuletFormatter : IMessagePackFormatter<AtgenSupportAmulet>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, AtgenSupportAmulet value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public AtgenSupportAmulet Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
