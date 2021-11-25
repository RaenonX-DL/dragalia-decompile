using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class ShopPreChargeCheckResponseFormatter : IMessagePackFormatter<ShopPreChargeCheckResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, ShopPreChargeCheckResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public ShopPreChargeCheckResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
