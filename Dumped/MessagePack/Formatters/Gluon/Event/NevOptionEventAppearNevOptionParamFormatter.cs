using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class NevOptionEventAppearNevOptionParamFormatter : IMessagePackFormatter<NevOptionEventAppearNevOptionParam>
	{
		public int Serialize(ref byte[] bytes, int offset, NevOptionEventAppearNevOptionParam value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public NevOptionEventAppearNevOptionParam Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
