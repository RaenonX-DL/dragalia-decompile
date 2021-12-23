using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class DebugDmodeUpdateDmodeRecoverCountResponseFormatter : IMessagePackFormatter<DebugDmodeUpdateDmodeRecoverCountResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, DebugDmodeUpdateDmodeRecoverCountResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DebugDmodeUpdateDmodeRecoverCountResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
