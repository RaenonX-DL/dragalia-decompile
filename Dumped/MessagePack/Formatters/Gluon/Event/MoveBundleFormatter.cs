using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class MoveBundleFormatter : IMessagePackFormatter<MoveBundle>
	{
		public int Serialize(ref byte[] bytes, int offset, MoveBundle value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public MoveBundle Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
