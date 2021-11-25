using MessagePack;
using MessagePack.Formatters;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class dummyFormatter : IMessagePackFormatter<dummy>
	{
		public int Serialize(ref byte[] bytes, int offset, dummy value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public dummy Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(dummy);
		}
	}
}
