using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class DmodeBuildupServitorPassiveResponseFormatter : IMessagePackFormatter<DmodeBuildupServitorPassiveResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, DmodeBuildupServitorPassiveResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DmodeBuildupServitorPassiveResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
