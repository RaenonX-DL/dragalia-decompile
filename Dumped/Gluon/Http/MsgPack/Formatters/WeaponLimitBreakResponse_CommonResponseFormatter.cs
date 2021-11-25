using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class WeaponLimitBreakResponse_CommonResponseFormatter : IMessagePackFormatter<WeaponLimitBreakResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, WeaponLimitBreakResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public WeaponLimitBreakResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
