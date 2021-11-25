using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class Clb01EventGetEventDataResponseFormatter : IMessagePackFormatter<Clb01EventGetEventDataResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, Clb01EventGetEventDataResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public Clb01EventGetEventDataResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
