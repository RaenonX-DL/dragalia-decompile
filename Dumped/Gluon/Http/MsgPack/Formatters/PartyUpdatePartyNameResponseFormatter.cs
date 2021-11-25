using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class PartyUpdatePartyNameResponseFormatter : IMessagePackFormatter<PartyUpdatePartyNameResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, PartyUpdatePartyNameResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public PartyUpdatePartyNameResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
