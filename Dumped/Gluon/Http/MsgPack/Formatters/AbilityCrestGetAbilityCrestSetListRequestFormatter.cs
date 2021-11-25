using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class AbilityCrestGetAbilityCrestSetListRequestFormatter : IMessagePackFormatter<AbilityCrestGetAbilityCrestSetListRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, AbilityCrestGetAbilityCrestSetListRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public AbilityCrestGetAbilityCrestSetListRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
