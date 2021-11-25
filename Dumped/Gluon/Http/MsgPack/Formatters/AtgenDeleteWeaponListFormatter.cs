using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class AtgenDeleteWeaponListFormatter : IMessagePackFormatter<AtgenDeleteWeaponList>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, AtgenDeleteWeaponList value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public AtgenDeleteWeaponList Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
