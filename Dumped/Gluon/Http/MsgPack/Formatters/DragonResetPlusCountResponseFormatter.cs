using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class DragonResetPlusCountResponseFormatter : IMessagePackFormatter<DragonResetPlusCountResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, DragonResetPlusCountResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DragonResetPlusCountResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
