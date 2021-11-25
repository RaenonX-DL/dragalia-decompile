using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class NevOptionEventOnShootOptionParamFormatter : IMessagePackFormatter<NevOptionEventOnShootOptionParam>
	{
		public int Serialize(ref byte[] bytes, int offset, NevOptionEventOnShootOptionParam value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public NevOptionEventOnShootOptionParam Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
