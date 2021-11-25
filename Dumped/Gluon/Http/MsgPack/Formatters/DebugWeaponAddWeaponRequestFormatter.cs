using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class DebugWeaponAddWeaponRequestFormatter : IMessagePackFormatter<DebugWeaponAddWeaponRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, DebugWeaponAddWeaponRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DebugWeaponAddWeaponRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
