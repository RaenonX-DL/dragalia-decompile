using MessagePack;
using MessagePack.Formatters;
using MessagePack.Internal;

namespace Gluon.Http.MsgPack.Formatters
{
	public sealed class TutorialUpdateStepRequestFormatter : IMessagePackFormatter<TutorialUpdateStepRequest>
	{
		private readonly AutomataDictionary ____keyMapping;

		private readonly byte[][] ____stringByteKeys;

		public int Serialize(ref byte[] bytes, int offset, TutorialUpdateStepRequest value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public TutorialUpdateStepRequest Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
