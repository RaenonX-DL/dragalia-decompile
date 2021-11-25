using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class AbilityCrestSetAbilityCrestSetResponseFormatter : IMessagePackFormatter<AbilityCrestSetAbilityCrestSetResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, AbilityCrestSetAbilityCrestSetResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public AbilityCrestSetAbilityCrestSetResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
