using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class AbilityCrestUpdateAbilityCrestSetNameResponse_CommonResponseFormatter : IMessagePackFormatter<AbilityCrestUpdateAbilityCrestSetNameResponse.CommonResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, AbilityCrestUpdateAbilityCrestSetNameResponse.CommonResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public AbilityCrestUpdateAbilityCrestSetNameResponse.CommonResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
