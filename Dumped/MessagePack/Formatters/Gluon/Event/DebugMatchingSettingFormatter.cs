using Gluon.Event;

namespace MessagePack.Formatters.Gluon.Event
{
	public sealed class DebugMatchingSettingFormatter : IMessagePackFormatter<DebugMatchingSetting>
	{
		public int Serialize(ref byte[] bytes, int offset, DebugMatchingSetting value, IFormatterResolver formatterResolver)
		{
			return default(int);
		}

		public DebugMatchingSetting Deserialize(byte[] bytes, int offset, IFormatterResolver formatterResolver, out int readSize)
		{
			return null;
		}
	}
}
