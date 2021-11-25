using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class HeroParamExDataFormatter : IMessagePackFormatter<HeroParamExData>
	{
		public int Serialize(ref byte[] bytes, int offset, HeroParamExData value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public HeroParamExData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
