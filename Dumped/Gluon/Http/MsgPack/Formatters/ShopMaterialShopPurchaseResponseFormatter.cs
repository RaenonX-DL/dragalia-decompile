using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class ShopMaterialShopPurchaseResponseFormatter : IMessagePackFormatter<ShopMaterialShopPurchaseResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, ShopMaterialShopPurchaseResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public ShopMaterialShopPurchaseResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
