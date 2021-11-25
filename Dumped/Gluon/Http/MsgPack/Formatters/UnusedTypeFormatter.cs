using MessagePack;
using MessagePack.Formatters;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class UnusedTypeFormatter : IMessagePackFormatter<UnusedType>
	{
		public int Serialize(ref byte[] bytes, int offset, UnusedType value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public UnusedType Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return default(UnusedType);
		}
	}
}
