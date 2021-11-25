using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class StatisticsFormatter : IMessagePackFormatter<Statistics>
	{
		public int Serialize(ref byte[] bytes, int offset, Statistics value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public Statistics Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
