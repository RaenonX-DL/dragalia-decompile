using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class ShopPreChargeCheckRequestFormatter : IMessagePackFormatter<ShopPreChargeCheckRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, ShopPreChargeCheckRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public ShopPreChargeCheckRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
