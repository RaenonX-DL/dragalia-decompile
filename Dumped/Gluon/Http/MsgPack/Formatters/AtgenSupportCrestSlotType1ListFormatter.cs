using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class AtgenSupportCrestSlotType1ListFormatter : IMessagePackFormatter<AtgenSupportCrestSlotType1List>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, AtgenSupportCrestSlotType1List value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public AtgenSupportCrestSlotType1List Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
