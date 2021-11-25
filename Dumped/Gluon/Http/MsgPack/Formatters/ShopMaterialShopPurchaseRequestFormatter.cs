using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class ShopMaterialShopPurchaseRequestFormatter : IMessagePackFormatter<ShopMaterialShopPurchaseRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, ShopMaterialShopPurchaseRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public ShopMaterialShopPurchaseRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
