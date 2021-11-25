using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class TransitionTransitionByNAccountResponseFormatter : IMessagePackFormatter<TransitionTransitionByNAccountResponse>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, TransitionTransitionByNAccountResponse value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public TransitionTransitionByNAccountResponse Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
