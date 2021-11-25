using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class WeaponLimitBreakRequestFormatter : IMessagePackFormatter<WeaponLimitBreakRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, WeaponLimitBreakRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public WeaponLimitBreakRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
