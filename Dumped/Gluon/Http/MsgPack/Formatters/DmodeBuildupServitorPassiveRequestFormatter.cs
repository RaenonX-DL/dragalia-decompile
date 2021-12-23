using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class DmodeBuildupServitorPassiveRequestFormatter : IMessagePackFormatter<DmodeBuildupServitorPassiveRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, DmodeBuildupServitorPassiveRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DmodeBuildupServitorPassiveRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
