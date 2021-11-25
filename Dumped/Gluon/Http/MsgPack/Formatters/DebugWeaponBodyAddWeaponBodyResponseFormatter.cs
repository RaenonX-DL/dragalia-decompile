using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class DebugWeaponBodyAddWeaponBodyResponseFormatter : IMessagePackFormatter<DebugWeaponBodyAddWeaponBodyResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, DebugWeaponBodyAddWeaponBodyResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DebugWeaponBodyAddWeaponBodyResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
