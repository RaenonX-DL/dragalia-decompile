using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class ApplyOpeningDebuffEventFormatter : IMessagePackFormatter<ApplyOpeningDebuffEvent>
	{
		public int Serialize(ref byte[] bytes, int offset, ApplyOpeningDebuffEvent value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public ApplyOpeningDebuffEvent Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
