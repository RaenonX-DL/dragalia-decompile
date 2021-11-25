using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class DispBuffCaptionEventFormatter : IMessagePackFormatter<DispBuffCaptionEvent>
	{
		public int Serialize(ref byte[] bytes, int offset, DispBuffCaptionEvent value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DispBuffCaptionEvent Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
