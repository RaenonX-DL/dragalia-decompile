using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class HeroParamFormatter : IMessagePackFormatter<HeroParam>
	{
		public int Serialize(ref byte[] bytes, int offset, HeroParam value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public HeroParam Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
