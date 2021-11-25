using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class AbilitySyncDataFormatter : IMessagePackFormatter<AbilitySyncData>
	{
		public int Serialize(ref byte[] bytes, int offset, AbilitySyncData value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public AbilitySyncData Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
